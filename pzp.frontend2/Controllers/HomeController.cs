using Microsoft.AspNetCore.Mvc;
using pzp.frontend2.Core.Services;
using pzp.frontend2.Models;
using System.Diagnostics;

namespace pzp.frontend2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MailSenderService _mailSenderService;

        public HomeController(ILogger<HomeController> logger, MailSenderService mailSenderService)
        {
            _logger = logger;
            _mailSenderService = mailSenderService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        
        public void SendMail(Mail model)
        {
            string from ="dasad33_79@o2.pl";
            string subject = model.Subject;
            string body = "aaaaaaaaaaa";
            _mailSenderService.Send(from, subject, body);
        }
    }
}