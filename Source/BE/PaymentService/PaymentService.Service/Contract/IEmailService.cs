using PaymentService.Domain.Settings;

namespace PaymentService.Service.Contract;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest mailRequest);

}