using System.Collections.Generic;
using System.Net.Mail;

namespace PlannedLibrary
{
    public class EmailLogic
    {
        public static void SendEmail(string toAddress, string subject, string body)
        {
            SendEmail(new List<string> { toAddress }, new List<string>(), subject, body);
        }

        public static void SendEmail(List<string> toAddress, List<string> bCCAddress, string subject, string body)
        {
            MailAddress fromAddress = new MailAddress(GlobalConfig.AppKeyLookUp("senderEmail"), GlobalConfig.AppKeyLookUp("senderDisplayName"));
            MailMessage mail = new MailMessage();

            mail.From = fromAddress;
            foreach (string to in toAddress)
            {
                mail.To.Add(to);

            }
            foreach (string bcc in bCCAddress)
            {
                mail.Bcc.Add(bcc);

            }

            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Send(mail);
        }
    }
}
