namespace PizzaCs.Infrastructure.Repository.Interfaces;

public interface IRepositoryWrapper
{
    IUserRepository UserRepository {  get; }
    IAccountRepository AccountRepository { get; }
    IMenuItemRepository MenuItemRepository { get; }
    IIngredientRepository IngredientRepository { get; }

    void Save();
}
