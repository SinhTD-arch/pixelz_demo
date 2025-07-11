using System.ComponentModel.DataAnnotations;

namespace PaymentService.Domain.Auth;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}