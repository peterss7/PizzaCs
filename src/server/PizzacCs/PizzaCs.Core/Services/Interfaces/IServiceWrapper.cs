namespace PizzaCs.Core.Services.Interfaces;

public interface IServiceWrapper
{
    IUserService UserService { get; }
    IAccountService AccountService { get; }
    IIngredientService IngredientService { get; }
    IMenuItemService MenuItemService { get; }
}
