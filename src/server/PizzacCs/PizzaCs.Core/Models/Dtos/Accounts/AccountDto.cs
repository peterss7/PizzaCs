using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCs.Core.Models.Dtos.Accounts;

public class AccountDto
{
    public Guid? ObjectKey { get; set; }
    public int? AccountId { get; set; }
    public string? AccountNumber { get; set; }
}
