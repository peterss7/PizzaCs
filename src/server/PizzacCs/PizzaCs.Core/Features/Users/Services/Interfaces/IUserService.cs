using PizzaCs.Core.Features.Users.Models.Dtos;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Models.Errors;

namespace PizzaCs.Core.Features.Users.Services.Interfaces;

public interface IUserService
{
    Task<PizzaResult> CreateUserAsync(CreateUserDto inputDto);
    Task<PizzaResult<UserDto>> GetUserByIdAsync(int id);
    Task<PizzaResult<List<UserDto>>> GetAllUsersAsync();
}
