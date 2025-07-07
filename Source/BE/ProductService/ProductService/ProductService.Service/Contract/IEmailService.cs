using ProductService.Domain.Settings;

namespace ProductService.Service.Contract;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest mailRequest);

}