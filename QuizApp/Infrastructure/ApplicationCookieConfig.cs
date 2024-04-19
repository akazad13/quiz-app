﻿namespace QuizApp.Infrastructure
{
    public static class ApplicationCookieConfig
    {
        public static void ConfigCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(config =>
            {
                config.ExpireTimeSpan = new TimeSpan(2, 0, 0);
                config.SlidingExpiration = true;
                config.Cookie.Name = "quizApp.Cookie";
                config.LoginPath = "/auth";
                config.AccessDeniedPath = "/auth/accessdenied";
                config.Cookie.SameSite = SameSiteMode.Lax;
            });
        }
    }
}
