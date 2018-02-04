using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class Yuuto_ANSWER_LIST
    {
        public Yuuto_ANSWER_LIST()
        {

        }
        Dictionary<string, string> answer_list = new Dictionary<string, string>();

        public void add_answer()
        {
            answer_list.Add("vpa name","my name is yuto and i love to do what you want me to do for you");
            answer_list.Add("time",DateTime.Today.ToString());
            answer_list.Add("sure i can send emails for you","sir you have 10 seconds please give me the information about email like receiver address and and message and subject");
        }

        public Dictionary<string,string> get_yuuto_answer_list()
        {
            return answer_list;
        }
    }
}
