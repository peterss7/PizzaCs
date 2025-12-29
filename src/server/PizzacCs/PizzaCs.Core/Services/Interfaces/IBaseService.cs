using PizzaCs.Infrastructure.Models.Errors;

namespace PizzaCs.Core.Services.Interfaces;

public interface IBaseService<TEntity, TDto>
{
    Task<PizzaResult<TDto?>> GetAsync(int id);
    Task<TDto?> CreateAsync(TDto inputDto);
}
