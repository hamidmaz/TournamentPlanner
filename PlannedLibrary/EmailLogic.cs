using System.Net.Mail;

namespace PlannedLibrary
{
    public class EmailLogic
    {
        public static void SendEmail(string toAddress, string subject, string body)
        {
            MailAddress fromAddress = new MailAddress(GlobalConfig.AppKeyLookUp("senderEmail"), GlobalConfig.AppKeyLookUp("senderDisplayName"));
            MailMessage mail = new MailMessage();

            mail.From = fromAddress;
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Send(mail);
        }
    }
}
