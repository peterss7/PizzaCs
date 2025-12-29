using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Base;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository;

public class IngredientRepository : BaseRepository<IngredientEfc>, IIngredientRepository
{
    public IngredientRepository(PizzaContext context, ILogger<IRepositoryWrapper> logger)
        : base(context, logger) { }
}
