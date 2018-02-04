using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    class SEND_GMAIL_EMAIL
    {
        public void send_email(string msg,string sub)
        {
            var fromAddress = new MailAddress("chinmayanand896@gmail.com", "Chinmay anand");
            var toAddress = new MailAddress("chinmayanand896@gmail.com", "Chinmay anand");
            const string fromPassword = "chinmaysuperuser";
            string subject = sub;
            string body = msg;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
