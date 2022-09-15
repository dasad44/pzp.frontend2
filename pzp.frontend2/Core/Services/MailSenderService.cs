using pzp.frontend2.Core.Helpers;
using pzp.frontend2.Infrastructure.Features;
using pzp.frontend2.Interfaces;
using pzp.frontend2.Models;

namespace pzp.frontend2.Core.Services
{
    public class MailSenderService : IMailSenderService
    {
        private readonly ISender _sender;

        public MailSenderService(ISender sender)
        {
            _sender = sender;
        }
        public void Send(Appointment appointment)
        {
            _sender.Send(new MailDetails()
            {
                Body = BodyTemplateCreator.SetBodyTemplate(appointment),
                Subject = appointment.Subject
            });
        }
    }
}
