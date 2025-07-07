using OrderService.Domain.Settings;

namespace OrderService.Service.Contract;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest mailRequest);

}