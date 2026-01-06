using AutoMapper;
using PizzaCs.Core.Features.Users.Models.Dtos;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Core.Features.Users.Models.Mapping;

public sealed class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserEfc, UserDto>();
        CreateMap<CreateUserDto, UserEfc>();        
    }
}
