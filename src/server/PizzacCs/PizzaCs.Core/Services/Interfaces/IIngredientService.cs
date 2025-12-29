using PizzaCs.Core.Models.Dtos.Ingredients;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Core.Services.Interfaces;

public interface IIngredientService : IBaseService<IngredientEfc, IngredientDto>
{ }
