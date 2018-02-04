using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class NEED_TO_SAVE_DATA
    {
        List<String> process_need_to_save_work = new List<String>();
        protected String result = null;
        protected int list_length = 0;
        public void add_data_to_list1()
        {
            process_need_to_save_work.Add("notepad");
            process_need_to_save_work.Add("microsoft word");
        }

        public int list_size()
        {
            list_length = process_need_to_save_work.Count;
            return list_length;
        }

        public String getdatafromthelist(int position)
        {
            result = null;
            result = process_need_to_save_work[position];
            return result;
        }
    }
}
