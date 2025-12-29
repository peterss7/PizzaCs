using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaCs.Infrastructure.Models.Entities;

public class AccountEfc
{
    [Key]
    public Guid ObjectKey { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AccountId {  get; set; }
    [Required]
    [MaxLength(32)]
    public string AccountNumber { get; set; }

}
