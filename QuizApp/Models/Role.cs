using Microsoft.AspNetCore.Identity;


namespace QuizApp.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
