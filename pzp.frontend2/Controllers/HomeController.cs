using Microsoft.AspNetCore.Mvc;
using pzp.frontend2.Core.Services;
using pzp.frontend2.Interfaces;
using pzp.frontend2.Models;

namespace pzp.frontend2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailSenderService _mailSenderService;
        private const string _scrollDownScript = "<script>setTimeout (function() {document.getElementById('appointment').scrollIntoView();}, 100);</script>";
        private const string _sweetAlertScriptError = "<script>swal('Błąd!', 'Nie udało się wysłać maila, spróbuj jeszcze raz', 'error');</script>";
        private const string _sweetAlertScriptSuccess = "<script>swal('Sukces!', 'Mail został wysłany pomyślnie', 'success');</script>";

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
                TempData["mailAlert"] = _sweetAlertScriptSuccess;
            }
            else
            {
                TempData["scrollDown"] = _scrollDownScript;
                TempData["mailAlert"] = _sweetAlertScriptError;
            }
            return View("Index");
        }
    }
}