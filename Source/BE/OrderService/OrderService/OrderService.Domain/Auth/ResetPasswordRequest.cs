using System.ComponentModel.DataAnnotations;

namespace OrderService.Domain.Auth;

public class ResetPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Token { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}