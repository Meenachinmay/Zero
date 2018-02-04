using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class GET_INSTANCE
    {
       public COMMAND_LIST cm_List = new COMMAND_LIST();
       public NEED_TO_SAVE_DATA savework_onShutdown = new NEED_TO_SAVE_DATA();
       public Yuuto_ANSWER_LIST yuuto_answer_list = new Yuuto_ANSWER_LIST();
       public SEND_GMAIL_EMAIL send_mail = new SEND_GMAIL_EMAIL();
       public READ_GMAIL_EMAIL read_email = new READ_GMAIL_EMAIL();
       public SW_FUNCTION showwindow_fun = new SW_FUNCTION();
       public VARIABLE_MANAGER variable_manager = new VARIABLE_MANAGER();
       public GET_INSTANCE()
       {

       }
    }
}
