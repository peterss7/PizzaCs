
using PizzaCs.Core.Utilities;
using PizzaCs.Core.Utilities.Interfaces;

namespace PizzacCs.Api.Extensions;

public static class UtilitiesStartupServices
{
    public static void ConfigureUtilitiesServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountNumberGenerator, AccountNumberGenerator>();
    }
}
