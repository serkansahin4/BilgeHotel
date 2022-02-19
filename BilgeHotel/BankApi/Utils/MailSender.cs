using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BankApi.Utils
{
    public class MailSender
    {
        public static void MailSend(string email, string subject, string message)
        {
            //MailMessage
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("bilgehoteldeneme@gmail.com", "Bilge Hotel");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            //SmtpClient
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgehoteldeneme@gmail.com", "123456+Bjk");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            smtp.Send(sender);

            //https://www.google.com/settings/security/lesssecureapps

        }
    }
}
