using pzp.frontend2.Infrastructure.Features;
using pzp.frontend2.Models;

namespace pzp.frontend2.Core.Services
{
    public class MailSenderService
    {
        private readonly MailSender _mailSender;

        public MailSenderService(MailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public void Send(Appointment appointment)
        {
            _mailSender.Send(appointment);
        }
    }
}
