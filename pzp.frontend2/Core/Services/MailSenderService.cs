using pzp.frontend2.Infrastructure.Features;

namespace pzp.frontend2.Core.Services
{
    public class MailSenderService
    {
        private readonly MailSender _mailSender;

        public MailSenderService(MailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public void Send(string from, string subject, string body)
        {
            _mailSender.Send(from, subject, body);
        }
    }
}
