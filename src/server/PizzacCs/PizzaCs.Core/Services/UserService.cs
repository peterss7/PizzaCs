using Microsoft.Extensions.Logging;
using PizzaCs.Core.Models.Dtos.Users;
using PizzaCs.Core.Services.Base;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Core.Utilities;
using PizzaCs.Core.Utilities.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Models.Errors;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Services;

public class UserService : BaseService<UserEfc, UserDto>, IUserService
{
    private readonly IAccountNumberGenerator _accountNumberGenerator;
    public UserService(
        IUserRepository repository, 
        ILogger<IServiceWrapper> logger,
        IAccountNumberGenerator accountNumberGenerator
    ) : base(repository, logger) 
    {
        _accountNumberGenerator = accountNumberGenerator;
    }


    public override async Task<UserDto?> CreateAsync(UserDto inputDto) 
    {
        UserDto result = new UserDto();
        //for (var attempt = 0; attempt < 5; attempt++)
        //{
        result.AccountNumber = _accountNumberGenerator.Generate();
        //}

        return result;
    }
}
