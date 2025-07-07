using Microsoft.AspNetCore.Mvc;
using PaymentService.Domain.Settings;
using PaymentService.Service.Contract;

namespace PaymentService.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/Mail")]
[ApiVersion("1.0")]
public class MailController(IEmailService mailService) : ControllerBase
{
    [HttpPost("send")]
    public async Task<IActionResult> SendMail([FromForm] MailRequest request)
    {
        await mailService.SendEmailAsync(request);
        return Ok();
    }

}