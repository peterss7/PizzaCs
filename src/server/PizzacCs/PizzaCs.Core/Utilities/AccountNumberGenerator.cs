using Microsoft.Extensions.Logging;
using PizzaCs.Core.Utilities.Interfaces;
using System.Security.Cryptography;

namespace PizzaCs.Core.Utilities;

public class AccountNumberGenerator : IAccountNumberGenerator
{
    ILogger<IAccountNumberGenerator> _logger;
    public AccountNumberGenerator(ILogger<IAccountNumberGenerator> logger)
    {
        _logger = logger;
    }
    public string Generate()
    {
        // 12-digit number, padded (no leading zeros problem)
        var n = RandomNumberGenerator.GetInt32(0, 1_000_000_000); // 9 digits
        var m = RandomNumberGenerator.GetInt32(0, 1_000);         // 3 digits
        string result = $"ACCT-{n:000000000}{m:000}";
        _logger.LogInformation(result);
        return result;
    }
}
