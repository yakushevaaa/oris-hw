using CarBooking.Data;
using CarBooking.Models;
using CarBooking.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class EmailController: ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("Email")]
        public IActionResult SendEmail([FromForm] EmailRequest request)
        {

            _emailService.SendEmail(request.Email, "Hello", "Контент");
            _emailService.LogEmail(request);
            return Ok();
        }
    }
   
    
}
