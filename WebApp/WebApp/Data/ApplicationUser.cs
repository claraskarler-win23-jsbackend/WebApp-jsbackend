using Microsoft.AspNetCore.Identity;

namespace WebApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int? AddressId { get; set; }
    public string? ProfileImage { get; set; } = "avatar.jpg";
    public AddressEntity? Address { get; set; }
    public string? Biography { get; set; }

}

