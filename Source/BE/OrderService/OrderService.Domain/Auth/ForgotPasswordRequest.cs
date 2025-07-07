using System.ComponentModel.DataAnnotations;

namespace OrderService.Domain.Auth;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}