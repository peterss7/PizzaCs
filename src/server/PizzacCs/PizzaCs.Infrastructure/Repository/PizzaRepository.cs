using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository;

public class PizzaRepository : IRepositoryWrapper
{
    private readonly PizzaContext _context;
    private readonly ILogger<IRepositoryWrapper> _logger;

    private IUserRepository _userRepository;
    private IAccountRepository _accountRepository;
    private IIngredientRepository _ingredientRepository;
    private IMenuItemRepository _menuItemRepository;

    public PizzaRepository(PizzaContext context,
        ILogger<IRepositoryWrapper> logger,
        IUserRepository userRepository,
        IAccountRepository accountRepository,
        IIngredientRepository ingredientRepository,
        IMenuItemRepository menuItemRepository)
    {
        _context = context;
        _logger = logger;
        _userRepository = userRepository;
        _accountRepository = accountRepository;
        _menuItemRepository = menuItemRepository;
        _ingredientRepository = ingredientRepository;
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

    public IAccountRepository AccountRepository
    {
        get
        {
            if (_accountRepository == null)
            {
                _accountRepository = new AccountRepository(_context, _logger);
            }
            return _accountRepository;
        }
    }

    public IMenuItemRepository MenuItemRepository
    {
        get
        {
            if (_menuItemRepository == null)
            {
                _menuItemRepository = new MenuItemRepository(_context, _logger);
            }
            return _menuItemRepository;
        }
    }

    public IIngredientRepository IngredientRepository
    {
        get
        {
            if (_ingredientRepository == null)
            {
                _ingredientRepository = new IngredientRepository(_context, _logger);
            }
            return _ingredientRepository;
        }
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
