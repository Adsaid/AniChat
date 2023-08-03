using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AniChat
{
    internal class SmtpEmail
    {
        private string fromMail = "anichatemailservice@gmail.com";
        private string fromPassword = "iajvmdrmrvouqmjj";

        public void Send(string toEmail, string subject, string text)
        {
            if (!String.IsNullOrEmpty(toEmail))
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = subject;
                message.To.Add(new MailAddress(toEmail));
                message.Body =$"<html><body>{text}</body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true
                };

                smtpClient.Send(message);
            }
        }
    }
}
