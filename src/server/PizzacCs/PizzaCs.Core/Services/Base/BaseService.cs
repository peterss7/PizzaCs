using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Logging;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Infrastructure.Models.Errors;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Services.Base;

public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto> 
    where TEntity : class
    where TDto : class
{
    protected readonly IBaseRepository<TEntity> _repository;
    protected readonly ILogger<IServiceWrapper> _logger;

    public BaseService(IBaseRepository<TEntity> repository, ILogger<IServiceWrapper> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public virtual async Task<TDto?> CreateAsync(TDto inputDto)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<PizzaResult<TDto?>> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
}
