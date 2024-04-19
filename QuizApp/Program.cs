using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using QuizApp.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDatabaseConfiguration(builder.Configuration);

// ASP.NET Identity Settings
builder.Services.AddIdentityConfiguration();

//Cookie
builder.Services.ConfigCookie();

builder.Services.AddServices();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
    options.AddPolicy("RequireStudentRole", policy => policy.RequireRole("Student"));
});

builder.Services
    .AddControllersWithViews(options =>
    {
        //  for adding authentication check
        var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
        options.Filters.Add(new AuthorizeFilter(policy));
    })
    .AddNewtonsoftJson(
        options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
                .Json
                .ReferenceLoopHandling
                .Ignore
    );

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.ShouldMapMethod = (m => false);
    mc.AddProfile(new AutoMapperProfiles());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Account}/{action=Index}/{id?}");

//using (var scope = app.Services.CreateScope())
//{
//    var initialiser = scope.ServiceProvider.GetRequiredService<Seed>();
//    await initialiser.InitialiseAsync();
//    await initialiser.SeedAsync();
//}

//app.Services.SeedDatabase();

app.Run();
