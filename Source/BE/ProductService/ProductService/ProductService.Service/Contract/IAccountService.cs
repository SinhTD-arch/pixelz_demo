using ProductService.Domain.Auth;
using ProductService.Domain.Common;

namespace ProductService.Service.Contract;

public interface IAccountService
{
    Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    Task<Response<string>> ConfirmEmailAsync(string userId, string code);
    Task ForgotPassword(ForgotPasswordRequest model, string origin);
    Task<Response<string>> ResetPassword(ResetPasswordRequest model);
}