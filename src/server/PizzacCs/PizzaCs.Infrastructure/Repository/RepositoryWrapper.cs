using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository;

public class RepositoryWrapper : IRepositoryWrapper
{
    private readonly PizzaContext _context;
    private IUserRepository _userRepository;
    
    private readonly ILogger<IRepositoryWrapper> _logger;

    public RepositoryWrapper(PizzaContext context,
        ILogger<IRepositoryWrapper> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IUserRepository UserRepository
    {
        get
        {
            if (_userRepository == null)
            {
                _userRepository = new UserRepository(_context, _logger);
            }
            return _userRepository;
        }
    }

    //public IAccountRepository AccountRepository
    //{
    //    get
    //    {
    //        if (_accountRepository == null)
    //        {
    //            _accountRepository = new AccountRepository(_context, _logger);
    //        }
    //        return _accountRepository;
    //    }
    //}

    //public IMenuItemRepository MenuItemRepository
    //{
    //    get
    //    {
    //        if (_menuItemRepository == null)
    //        {
    //            _menuItemRepository = new MenuItemRepository(_context, _logger);
    //        }
    //        return _menuItemRepository;
    //    }
    //}

    //public IIngredientRepository IngredientRepository
    //{
    //    get
    //    {
    //        if (_ingredientRepository == null)
    //        {
    //            _ingredientRepository = new IngredientRepository(_context, _logger);
    //        }
    //        return _ingredientRepository;
    //    }
    //}

    public void Save()
    {
        throw new NotImplementedException();
    }
}
