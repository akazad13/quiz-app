using QuizApp.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace QuizApp.Infrastructure
{
    public static class ServiceRegister
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IQuizRepository, QuizRepository>();
        }
    }
}
