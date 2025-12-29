using Microsoft.Extensions.Logging;
using PizzaCs.Core.Models.Dtos.Ingredients;
using PizzaCs.Core.Services.Base;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Services;

public class IngredientService : BaseService<IngredientEfc, IngredientDto>, IIngredientService
{
    public IngredientService(IIngredientRepository repository, ILogger<IServiceWrapper> logger)
        : base(repository, logger)
        { }
}
