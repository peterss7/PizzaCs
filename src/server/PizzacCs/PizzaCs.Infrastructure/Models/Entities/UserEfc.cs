using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaCs.Infrastructure.Models.Entities;

public class UserEfc
{
    [Key]
    public Guid ObjectKey { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    //[Required]
    //[MaxLength(100)]
    //public string UserName { get; set; }    
    //[MaxLength(254)]
    //public string UserEmail { get; set; }
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    //[Required]    
    //public Guid AccountNumber {  get; set; }

    //[ForeignKey(nameof(AccountNumber))]
    //public AccountEfc Account {  get; set; }
}
