using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.Contracts.Auth;
using Restaurant.BLL.Services;
using Restaurant.BLL.Services.Auth;
using Restaurant.BLL.Utilities;
using Restaurant.DAL;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Repository;

namespace Restaurant.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection serviceCollection) =>
        serviceCollection.AddDbContext<ApplicationContext>();

    public static void ConfigureMapper(this IServiceCollection serviceCollection) =>
        serviceCollection.AddAutoMapper(typeof(AutoMapperProfile));

    public static void ConfigureRepositoryManager(this IServiceCollection serviceCollection) =>
        serviceCollection.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureServiceManager(this IServiceCollection serviceCollection) =>
        serviceCollection.AddScoped<IServiceManager, ServiceManager>();
    
    public static void ConfigureAuth(this IServiceCollection serviceCollection)
    {
        var configuration = serviceCollection.BuildServiceProvider().GetService<IConfiguration>()!;
        var secretKey = configuration["JWTOptions:SecretKey"]!;
        
        serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };

                options.Events = new JwtBearerEvents()
                {
                    OnMessageReceived = context =>
                    {
                        context.Token = context.Request.Cookies["something"];

                        return Task.CompletedTask;
                    }
                };
            });

        serviceCollection.AddScoped<IJwtProvider, JwtProvider>();
        serviceCollection.AddScoped<IPasswordHasher, PasswordHasher>();
    }
}