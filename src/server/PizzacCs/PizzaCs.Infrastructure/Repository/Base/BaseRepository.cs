using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository.Base;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly PizzaContext _context;
    protected readonly ILogger<IRepositoryWrapper> _logger;

    public BaseRepository(PizzaContext context, ILogger<IRepositoryWrapper> logger)
    {
        _context = context;
        _logger = logger;
    }

    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
