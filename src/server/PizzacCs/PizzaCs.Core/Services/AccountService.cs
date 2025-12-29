using Microsoft.Extensions.Logging;
using PizzaCs.Core.Models.Dtos.Accounts;
using PizzaCs.Core.Services.Base;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Services;

public class AccountService : BaseService<AccountEfc, AccountDto>, IAccountService
{
    public AccountService(IAccountRepository repository, ILogger<IServiceWrapper> logger)
        : base(repository, logger) { }
}
