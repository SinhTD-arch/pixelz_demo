using System.ComponentModel.DataAnnotations;

namespace ProductService.Domain.Auth;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}