using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    public partial class Alert_Notification : Form
    {
        public Alert_Notification(string message, AlertType alertType)
        {
            InitializeComponent();

            switch (alertType)
            {
                case AlertType.battery:
                    
                    battery.Text = message;
                    break;
                case AlertType.time:
                    
                    battery.Text = message;
                    break;
                case AlertType.power_status:
                    
                    battery.Text = message;
                    break;
                case AlertType.connection_status:
                    battery.Text = message;
                    break;
            }
        }

        public static void Show_Notification_Alert(string message, AlertType alertType)
        {
            new Yuuto_VPA_Virtual_Private_Assistant_.Alert_Notification(message, alertType).Show();
        }

        public enum AlertType
        {
            battery, time, power_status,connection_status
        }

        private void battery_Click(object sender, EventArgs e)
        {

        }

        private void Alert_Notification_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            show.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void closealert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2;
            }
            else
            {
                this.Close();
            }
        }
    }
}
