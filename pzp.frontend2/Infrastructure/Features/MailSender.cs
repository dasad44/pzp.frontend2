using System.Net.Mail;

namespace pzp.frontend2.Infrastructure.Features
{
    public class MailSender
    {
        public void Send(string from, string subject, string body)
        {
            string to = "dasad44_79@o2.pl";
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception)
            {}
        }
    }
}
