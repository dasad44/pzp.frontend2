using pzp.frontend2.Models;
using System.Net;
using System.Net.Mail;

namespace pzp.frontend2.Infrastructure.Features
{
    public class MailSender
    {
        public void Send(Appointment appointment)
        {
            string to = "dasad44_79@o2.pl";
            MailMessage message = new MailMessage("kontaktpielegniarki@gmail.com", "dasad44_79@o2.pl");
            message.Subject = appointment.Subject;
            message.Body = appointment.Body;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("kontaktpielegniarki@gmail.com", "Dajciepieniadze");
            client.EnableSsl = true;
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
