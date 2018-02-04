using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class READ_GMAIL_EMAIL
    {
        string unseen_result;
        string seen_result;
        public string read_emails()
        {
            using (Imap imap = new Imap()){
                imap.ConnectSSL("imap.gmail.com");
                imap.Login("chinmayanand896@gmail.com","chinmaysuperuser");
                imap.SelectInbox();

                List<long> unseen_mail = imap.Search(Flag.Unseen);
                List<long> seen_main = imap.Search(Flag.Seen);

                foreach (long unseen_uid in unseen_mail){
                    IMail email = new MailBuilder().CreateFromEml(imap.GetMessageByUID(unseen_uid));

                    unseen_result = email.TextDataString;   
                }
            }

            return unseen_result;
        }
    }
}
