using System.ComponentModel.DataAnnotations;

public class UserProfile
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public required string Email { get; set; }

}

