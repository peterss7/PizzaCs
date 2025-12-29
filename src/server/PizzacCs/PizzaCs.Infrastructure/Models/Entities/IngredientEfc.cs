using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaCs.Infrastructure.Models.Entities;

public interface IngredientEfc
{
    [Key]
    public Guid ObjectKey { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IngredientId { get; set; }
    [Required]
    [MaxLength(100)]
    public string IngredientName { get; }
}
