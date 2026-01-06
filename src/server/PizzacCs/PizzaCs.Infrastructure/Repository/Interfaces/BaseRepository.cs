using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Infrastructure.Repository.Interfaces;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly PizzaContext _context;
    protected readonly ILogger<IRepositoryWrapper> _logger;

    public BaseRepository(PizzaContext context, ILogger<IRepositoryWrapper> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public abstract Task<T?> GetByIdAsync(int id);

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }


    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
