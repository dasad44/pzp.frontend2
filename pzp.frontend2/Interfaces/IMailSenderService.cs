using pzp.frontend2.Models;

namespace pzp.frontend2.Interfaces
{
    public interface IMailSenderService
    {
        void Send(Appointment appointment);
    }
}
