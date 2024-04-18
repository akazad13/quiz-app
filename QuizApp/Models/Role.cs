using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace QuizApp.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
