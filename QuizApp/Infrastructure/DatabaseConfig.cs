using QuizApp.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace QuizApp.Infrastructure
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<DataContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
