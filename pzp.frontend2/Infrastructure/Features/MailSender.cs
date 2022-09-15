using pzp.frontend2.Interfaces;
using pzp.frontend2.Models;
using System.Net;
using System.Net.Mail;

namespace pzp.frontend2.Infrastructure.Features
{
    public class MailSender : ISender
    {
        private MailMessage _message;
        private readonly SmtpClient _client;
        private const int port = 587;
        private const string host = "smtp.gmail.com";
        private readonly IConfiguration _configuration;

        public MailSender(IConfiguration configuration)
        {
            _client = new SmtpClient(host, port);
            _configuration = configuration;
        }

        private void UseCredentials()
        {
            _client.Credentials = new NetworkCredential(_configuration["MailService:From"], _configuration["MailService:Password"]);
        }

        private void SetMailContext(MailDetails mailDetails)
        {
            _message = new MailMessage(_configuration["MailService:From"], _configuration["MailService:To"]); 
            _message.Subject = mailDetails.Subject;
            _message.Body = mailDetails.Body;
        }
        public void Send(MailDetails mailDetails)
        {
            SetMailContext(mailDetails);
            UseCredentials();
            _client.EnableSsl = true;

            try
            {
                _client.Send(_message);
            }
            catch (Exception)
            {
                //todo: dodać jakis exception jeżeli maila nie uda sie wyslac            
            }
        }
    }
}
