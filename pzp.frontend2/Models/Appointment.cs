using pzp.frontend2.Enums;
using System.ComponentModel.DataAnnotations;

namespace pzp.frontend2.Models
{
    public class Appointment
    {
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nie podano nazwiska")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Nie podano maila")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Podano nieprawidłowy mail")]
        public string Email { get; set; }
        public string? Subject { get; set; }
        [Required(ErrorMessage = "Podaj treść wiadomości")]
        public string Body { get; set; }
        public Service Service { get; set; }
        [Required(ErrorMessage = "Nie podano numeru telefonu")]
        [RegularExpression(@"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", ErrorMessage = "Podano nieprawidłowy numer telefonu")]
        public string PhoneNumber { get; set; }
    }
}
