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
            _mailSenderService.Send(model);
            return View("Index");
        }
    }
}