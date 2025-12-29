using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaCs.Infrastructure.Models.Entities;

public class MenuItemEfc
{
    [Key]
    public Guid ObjectKey { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public int MenuItemId {  get; set; }
    [Required]
    [MaxLength(100)]
    public string MenuItemName { get; set; }
    [Required]
    [MaxLength(100)]
    public double Price { get; set; }
    public bool Available { get; set; }
    public List<IngredientEfc> Ingredients { get; set; }

}
