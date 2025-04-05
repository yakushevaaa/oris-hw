using CarBooking.Models;
using MimeKit;

namespace CarBooking.Services
{
    public interface IEmailService
    {
        public void SendEmail(string email, string subject, string content);
        public Task SendMessage(MimeMessage message);
        public Task LogEmail(EmailRequest emailRequest);

    }
}
