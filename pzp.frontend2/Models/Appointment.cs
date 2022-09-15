using pzp.frontend2.Enums;

namespace pzp.frontend2.Models
{
    public class Appointment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Service Service { get; set; }
        public string PhoneNumber { get; set; }
    }
}
