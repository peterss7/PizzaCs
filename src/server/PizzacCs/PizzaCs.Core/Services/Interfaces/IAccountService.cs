using PizzaCs.Core.Models.Dtos.Accounts;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Core.Services.Interfaces;

public interface IAccountService : IBaseService<AccountEfc, AccountDto>
{ }
