using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class COMMAND_LIST
    {
        List<String> super_commands_list = new List<String>();
        List<String> official_work_commands_list = new List<String>();
        List<String> searching_commands_list = new List<String>();
        List<String> iot_commands_list = new List<String>();
        List<String> local_work_commands_list = new List<String>();
        public COMMAND_LIST()
        {
            adding_super_commands();
            adding_official_work_commands();
            adding_searching_commands();
            adding_iot_commands();
            adding_localwork_commands();
        }
        
        public void adding_super_commands()
        {
            super_commands_list.Add("hey zero show start menu");
            super_commands_list.Add("hey zero show desktop");
            super_commands_list.Add("hey zero what is the time now");
            super_commands_list.Add("hey zero what time it is");
            super_commands_list.Add("hey zero bye bye go off now");
            super_commands_list.Add("hey zero go to sleep now see you soon");
            super_commands_list.Add("hey zero go to sleep now");
            super_commands_list.Add("hey zero can you please send a email for me");
            super_commands_list.Add("hey zero lock my pc now");
            super_commands_list.Add("hey zero lock it");
            super_commands_list.Add("lock your self");
            super_commands_list.Add("ok close now");
            super_commands_list.Add("show start menu");
            super_commands_list.Add("can you please send a email for me");
            super_commands_list.Add("open my computer");
            super_commands_list.Add("close this");
            super_commands_list.Add("show my battery level");
            super_commands_list.Add("what is my battery level");
            super_commands_list.Add("what time it is");
            super_commands_list.Add("hows weather today");
            super_commands_list.Add("show power status");
            super_commands_list.Add("show internet connection status");
        }

        public void adding_official_work_commands()
        {
            
        }

        public void adding_searching_commands()
        {

        }

        public void adding_iot_commands()
        {

        }

        public void adding_localwork_commands()
        {
            local_work_commands_list.Add("ammm cancel it");
            local_work_commands_list.Add("cancel it");
        }
        public List<String> get_command_list()
        {
            return super_commands_list;
        }

        public List<String> get_local_work_command_list() 
        {
            return local_work_commands_list;    
        }
    }
}
