using AutoMapper;
using Microsoft.Extensions.Logging;
using PizzaCs.Core.Features.Users.Models.Dtos;
using PizzaCs.Core.Features.Users.Services.Interfaces;
using PizzaCs.Core.Models.Errors;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Models.Errors;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Features.Users.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<IUserService> _logger;


    public UserService(
        IUserRepository repository,
        IMapper mapper,
        ILogger<IUserService> logger
    )
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public UserDto ToDto(UserEfc user) => _mapper.Map<UserDto>(user);

    public UserEfc ToEfc(UserDto userDto) => _mapper.Map<UserEfc>(userDto);
    public UserEfc ToEfc(CreateUserDto inputDto) => _mapper.Map<UserEfc>(inputDto);

    public async Task<PizzaResult> CreateUserAsync(CreateUserDto inputDto)
    {
        PizzaResult result = new PizzaResult();

        try
        {
            UserEfc newUser = ToEfc(inputDto);

            await _repository.CreateAsync(newUser);
            _repository.SaveChanges();            
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error 500 in {nameof(UserService)}, method {nameof(CreateUserAsync)}, message: {ex.Message}");
            return PizzaResult<UserDto>.Fail(PizzaError.InternalServerError, message: ex.Message);
        }

        return result.Ok(message: "Created new user successfully.");
    }

    public async Task<PizzaResult<List<UserDto>>> GetAllUsersAsync()
    {
        PizzaResult<List<UserDto>> result = new PizzaResult<List<UserDto>>();

        try
        {
            List<UserEfc> users = await _repository.GetAllAsync();

            if (users == null)
            {
                result.AddError(PizzaError.NotFound, "Users list is null.");
                return result;
            }

            if (users?.Count == 0)
            {
                result.AddError(PizzaError.NotFound, "Users list is empty.");
                return result;
            }

            result.Value = users?.Select(u => _mapper.Map<UserDto>(u)).ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            result.AddError(PizzaError.InternalServerError);
        }

        return result;
    }

    public async Task<PizzaResult<UserDto>> GetUserByIdAsync(int id)
    {
        PizzaResult<UserDto> result = new PizzaResult<UserDto>();
        
        try
        {
            UserEfc? user = await _repository.GetByIdAsync(id);

            if (user == null)
            {
                result.AddError(PizzaError.NotFound, $"No user of id {id} found.");
                return result;
            }

            result.Value = _mapper.Map<UserDto>(user);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            result.AddError(PizzaError.InternalServerError);
        }
        
        return result;
    }
}
