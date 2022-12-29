using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DiseñoIconos.CorreoElectronico
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void IniatilizeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void SendMail(string subject, string body, List<string> recipentMail)
        {

            var mailMessage = new MailMessage();

          

            try
            {
                mailMessage.From = new MailAddress(senderMail);

                foreach (string mail in recipentMail)
                { 
                    mailMessage.To.Add(mail); 
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }

    }
}
