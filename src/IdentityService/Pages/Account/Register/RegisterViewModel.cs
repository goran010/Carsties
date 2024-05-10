using System.ComponentModel.DataAnnotations;

namespace IdentityService;

public class RegisterViewModel
{
    [Required]
    public string Email { get; set; } = string.Empty; // Initialized to prevent warning

    [Required]
    public string Password { get; set; } = string.Empty;

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string FullName { get; set; } = string.Empty;

    public string? ReturnUrl { get; set; } // Nullable, it's okay if this is null

    public string? Button { get; set; }
}
