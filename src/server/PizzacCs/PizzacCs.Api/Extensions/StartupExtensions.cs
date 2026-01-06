
using Microsoft.EntityFrameworkCore;
using PizzaCs.Core.Features.Users.Models.Mapping;
using PizzaCs.Core.Features.Users.Services;
using PizzaCs.Core.Features.Users.Services.Interfaces;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Repository;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzacCs.Api.Extensions;

public static class StartupExtensions
{
    public static void StartupApplication(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.StartupRepositories();
        services.StartupServices();
        services.StartupAutomapper();
        services.ConfigureDbContext(configuration);
        services.ConfigureSwagger();
        services.ConfigureControllers();
        services.ConfigureCors();
    }

    private static void StartupRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
    }

    private static void StartupServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }

    private static void StartupAutomapper(this IServiceCollection services)
    {
        services.AddAutoMapper(config => 
        {
            config.AddMaps(typeof(UserMappingProfile).Assembly);
        });
    }

    private static void ConfigureDbContext(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<PizzaContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }

    private static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    private static void ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers();
    }

    private static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontend",
                policy =>
                {
                    policy
                        .WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });
    }
}
