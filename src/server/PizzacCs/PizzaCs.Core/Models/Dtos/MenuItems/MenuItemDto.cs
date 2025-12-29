using PizzaCs.Infrastructure.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCs.Core.Models.Dtos.MenuItems;

public class MenuItemDto
{
    public Guid? ObjectKey { get; set; }
    public int? MenuItemId { get; set; }
    public string? MenuItemName { get; set; }
    public double? Price { get; set; }
    public bool? Available { get; set; }
    public List<IngredientEfc?> Ingredients { get; set; }
}
