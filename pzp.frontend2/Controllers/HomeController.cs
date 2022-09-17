using Microsoft.AspNetCore.Mvc;
using pzp.frontend2.Core.Services;
using pzp.frontend2.Interfaces;
using pzp.frontend2.Models;

namespace pzp.frontend2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailSenderService _mailSenderService;

        public HomeController(IMailSenderService mailSenderService)
        {
            _mailSenderService = mailSenderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMail(Appointment model)
        {
            if (ModelState.IsValid)
            {
                _mailSenderService.Send(model);
                TempData["mailAlert"] = "<script>alert('Mail wysłany pomyślnie!');</script>";
            }
            else
            {
                TempData["mailAlert"] = "<script>alert('Wysyłanie maila nie powiodło się :(');</script>";
            }
            return View("Index");
        }
    }
}