using PizzaCs.Core.Models.Dtos.Users;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Core.Services.Interfaces;

public interface IUserService : IBaseService<UserEfc, UserDto>
{ }
