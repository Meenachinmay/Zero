using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using Limilabs.Client.IMAP;
using Microsoft.VisualBasic;
using WindowsInput;
using System.Net.NetworkInformation;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    public partial class Main_Class : MetroFramework.Forms.MetroForm
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        //to use show window function
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int Reserved);

        static SpeechRecognitionEngine Main_Engine;
        static SpeechRecognitionEngine email_rec_engine;
        SpeechSynthesizer yuuto = new SpeechSynthesizer();
        static Choices super_commands_choices,local_work_command_choices;
        GET_INSTANCE get_instance = new GET_INSTANCE();
        static List<String> super_command_List = new List<String>();
        static List<String> send_email_data = new List<String>();
        Dictionary<string, string> yutto_answers = new Dictionary<string, string>();
        public Main_Class()
        {
            InitializeComponent();
            yuuto.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            yuuto.Volume = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initializing objects
            Main_Engine = new SpeechRecognitionEngine();
            email_rec_engine = new SpeechRecognitionEngine();
            //showing console in form application
            AllocConsole();
            //initializing the object of choices
            super_commands_choices = new Choices();
            local_work_command_choices = new Choices();
            super_command_List = get_instance.cm_List.get_command_list();
            send_email_data = get_instance.cm_List.get_local_work_command_list();
            yutto_answers = get_instance.yuuto_answer_list.get_yuuto_answer_list();
            //adding all the grammer into to create a grammer for matching
            if(super_command_List.Count > 0){
                foreach(string word in super_command_List){
                    super_commands_choices.Add(word.ToString());
                }
            }
            else
            {
                MessageBox.Show("please add some data into your command list!");
            }
            if (send_email_data.Count > 0)
            {
                foreach (string word in send_email_data)
                {
                    local_work_command_choices.Add(word.ToString());
                }
            }
            else {
                MessageBox.Show("Please add some data into local work command list!");
            }
            //creating 1st speech engine
           // recEngine.RequestRecognizerUpdate();
            Main_Engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(super_commands_choices)));
            Main_Engine.SetInputToDefaultAudioDevice();
            Main_Engine.RecognizeAsync(RecognizeMode.Multiple);
            Main_Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeachRecognized);
            //creating 2nd speech engine
           // rec.RequestRecognizerUpdate();
            email_rec_engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(local_work_command_choices)));
            email_rec_engine.SetInputToDefaultAudioDevice();

        }
        //creating new object of rec engine
        public static void create_rec_new()
        {
            email_rec_engine = new SpeechRecognitionEngine();
            //rec.RequestRecognizerUpdate();
            email_rec_engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(local_work_command_choices)));
            email_rec_engine.SetInputToDefaultAudioDevice();
        }

        //creating new object of recEngine engine
        public static void create_MainEngine_new()
        {
            Main_Engine = new SpeechRecognitionEngine();
            Main_Engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(super_commands_choices)));
            Main_Engine.SetInputToDefaultAudioDevice();
            Main_Engine.RecognizeAsync(RecognizeMode.Multiple);
            Main_Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeachRecognized);
        }
        //event of Emailrecengine
        private static void Email_rec_engine_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string res = e.Result.Text;
            if(res.Equals("cancel it")){
                email_rec_engine.Dispose();
                create_MainEngine_new();
                close_mail_form();
            }
            else if(res.Equals("reset"))
            {
                
            }else if(res.Equals("ok send it")){
                
            }
        }
        //to refresh the mainEngine
        public static void refresh_main_engine()
        {
            email_rec_engine.Dispose();
            create_MainEngine_new();
        }
        //event of recEngine "MAIN EXECUTION" area of all the commands
        private static void recEngine_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //if(e.Result)
           // {
            string result = e.Result.Text;
            if (Main_Engine == null)
            {
                create_MainEngine_new();
            }
            //main if
            if (result.Equals("can you please send a email for me"))
            {
                Main_Engine.Dispose();
                create_rec_new();
                email_rec_engine.RecognizeAsync(RecognizeMode.Multiple);
                email_rec_engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Email_rec_engine_SpeachRecognized);
                getemaildata("chinu", "chinu");
            }
            else if (result.Equals("ok close now"))
            {
                Environment.Exit(0);
            }
            else if (result.Equals("show start menu"))
            {
                //MessageBox.Show(result.ToString());
                InputSimulator.SimulateKeyPress(VirtualKeyCode.LWIN);
            }
            else if (result.Equals("open my computer"))
            {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_E);
            }
            else if (result.Equals("close start menu"))
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.LWIN);
            }
            else if (result.Equals("close this"))
            {
                InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.F4);
            }
            else if (result.Equals("what is my battery level"))
            {
                string batry = SystemInformation.PowerStatus.BatteryLifePercent.ToString("P0");
                string final_batry = "Battery Level :";
                final_batry += batry;
                Alert_Notification.Show_Notification_Alert(final_batry, Alert_Notification.AlertType.battery);
            }
            else if (result.Equals("show my battery level"))
            {
                string batry = SystemInformation.PowerStatus.BatteryLifePercent.ToString("P0");
                string final_batry = "Battery Level :";
                final_batry += batry;
                Alert_Notification.Show_Notification_Alert(final_batry, Alert_Notification.AlertType.battery);
            }
            else if (result.Equals("what time it is"))
            {
                string time = DateTime.Now.ToString("h:mm:ss tt");
                Alert_Notification.Show_Notification_Alert(time, Alert_Notification.AlertType.battery);
            }
            else if (result.Equals("hows weather today"))
            {
                Weather_information.Show_Weather_notification("London","GB");
            }
            else if (result.Equals("show power status"))
            {
                PowerLineStatus status = SystemInformation.PowerStatus.PowerLineStatus;
                if (status == PowerLineStatus.Offline)
                {
                    Alert_Notification.Show_Notification_Alert("Running on battery",Alert_Notification.AlertType.power_status);
                }
                else
                {
                    Alert_Notification.Show_Notification_Alert("Running on power supply", Alert_Notification.AlertType.power_status);
                }
            }
            else if (result.Equals("show internet connection status"))
            {
                int des;
                string res = InternetGetConnectedState(out des, 0).ToString();
                if (res.Equals("True"))
                {
                    Alert_Notification.Show_Notification_Alert("Net is connected", Alert_Notification.AlertType.connection_status);
                }
                else
                {
                    Alert_Notification.Show_Notification_Alert("Internet is not working", Alert_Notification.AlertType.connection_status);
                }
            }
            //}
        }

        public static List<string> break_string(string data)
        {
            List<string> temp_list = new List<string>();
            string ans = "";
            for (int i = 0; i < data.Length; i ++ )
            {
                if(data[i] == ' '){
                    for (int j = i - 1; j >= 0 || j > ' '; j -- )
                    {
                        ans += data[j];
                    }
                    temp_list.Add(ans);             
                    ans = "";
                }
            }
            return temp_list;
        }
        //getting data to send email
        public static void  getemaildata(string rec,string sub)
        {
            //object of another form data getting form for sending email
            Getdataformail Mform = new Getdataformail();
           
            List<string> data = new List<string>();
            Mform.subjecttext.Text = sub;
            string msg = Mform.messagetext.Text;
            Mform.recipientstext.Text = rec;
            Mform.ShowDialog();
            data.Add(rec);//0
            data.Add(sub);//1
            data.Add(msg);//2
            //return data;
        }

        public static List<string> cancel_mail(string rec,string sub,string msg)
        {
            Getdataformail Mform = new Getdataformail();
            List<string> data = new List<string>();
            Mform.subjecttext.Text = sub;
            Mform.messagetext.Text = msg;
            Mform.recipientstext.Text = rec;
            data.Add(rec);//0
            data.Add(sub);//1
            data.Add(msg);//2
            return data;
        }
        //method to close email form
        public static void close_mail_form()
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.MENU,VirtualKeyCode.F4);
        }
        //method to try to reset all the values in email form
        
    }
}
