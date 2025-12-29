using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCs.Core.Models.Dtos.Ingredients;

public class IngredientDto
{
    public Guid? ObjectKey { get; set; }
    public int? IngredientId { get; set; }
    public string? IngredientName { get; }
}
