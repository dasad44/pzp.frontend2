using pzp.frontend2.Models;

namespace pzp.frontend2.Core.Helpers
{
    public static class BodyTemplateCreator
    {
        public static string SetBodyTemplate(Appointment appointment)
        {
            return $"Dane klienta: {appointment.FirstName} {appointment.LastName}\n" +
                $"Numer telefonu: {appointment.PhoneNumber}\n" +
                $"Mail: {appointment.Email}\n\n" +
                $"Usługa: {appointment.Service}\n\n" +
                $"{appointment.Body}"; 
        }
    }
}
