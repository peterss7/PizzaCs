using PizzaCs.Core.Models.Dtos.Accounts;
using PizzaCs.Core.Models.Dtos.Ingredients;
using PizzaCs.Core.Models.Dtos.MenuItems;
using PizzaCs.Core.Models.Dtos.Users;
using PizzaCs.Core.Services;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzacCs.Api.Extensions;

public static class CoreStartupServices
{
    public static void ConfigureCoreServices(this IServiceCollection services)
    {
        services.ConfigureServices();
        services.ConfigureRespositories();
    }

    private static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IBaseService<UserEfc, UserDto>, UserService>();        
        services.AddScoped<IBaseService<AccountEfc, AccountDto>, AccountService>();
        services.AddScoped<IBaseService<IngredientEfc, IngredientDto>, IngredientService>();
        services.AddScoped<IBaseService<MenuItemEfc, MenuItemDto>, MenuItemService>();
    }

    private static void ConfigureRespositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
        services.AddScoped(typeof(IAccountRepository), typeof(AccountRepository));
        services.AddScoped(typeof(IMenuItemRepository), typeof(MenuItemRepository));
        services.AddScoped(typeof(IIngredientRepository), typeof(IngredientRepository));
    }
}
