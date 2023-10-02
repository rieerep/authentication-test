using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationLab.Models
{
    public class UserModel : IdentityUser
    {
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
