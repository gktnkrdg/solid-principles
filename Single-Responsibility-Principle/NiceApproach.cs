using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace S.O.L.I.D.Single_Responsibility_Principle
{
    class NiceApproach
    {
        public class EmailService
        {
            public void ValidateEmail(string email)
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    throw new Exception("Email is not valid!!");
                }
            }
            public void SendEmail(string email, string message)
            {
                ValidateEmail(email);
                SmtpClient client = new SmtpClient();
                client.Send(new MailMessage("test@email.com", email) { Subject = "Test mail subject!" });
            }
        }
    }
}
