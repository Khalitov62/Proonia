using Microsoft.AspNetCore.Identity;

namespace Ap204_Pronia.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
