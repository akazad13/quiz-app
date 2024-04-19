using QuizApp.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace QuizApp.Repository
{
    public class AccountRepository(DataContext context) : IAccountRepository
    {
        private readonly DataContext _context = context;

        public async Task<IEnumerable<object>> GetUsersWithRoles()
        {
            return await _context.Users
                .OrderBy(x => x.UserName)
                .Select(user => new
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Roles = (from userRole in user.UserRoles
                             join role in _context.Roles
                             on userRole.RoleId equals role.Id
                             select role.Name).ToList()
                }).ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
    }
}
