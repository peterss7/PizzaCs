using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PizzaCs.Core.Features.Users.Models.Dtos;
using PizzaCs.Core.Features.Users.Services.Interfaces;

namespace PizzacCs.Api.Controllers;

[Route(API_ROUTE)]
[ApiController]
public class UserController : Controller
{
    public const string API_ROUTE = "api/users";
    public const string GET_ALL_ROUTE = "";
    public const string GET_ROUTE = "{id}";
    public const string CREATE_ROUTE = "";

    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    private readonly ILogger<UserController> _logger;

    public UserController(
        IUserService userService,
        IMapper mapper,
        ILogger<UserController> logger)
    {
        _userService = userService;
        _mapper = mapper;
        _logger = logger;
    }

    
    [HttpPost(CREATE_ROUTE)]
    [ProducesResponseType(201)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public async Task<ActionResult> CreateUser([FromBody] CreateUserDto inputDto)
    {
        try
        {
            var result = await _userService.CreateUserAsync(inputDto);

            if (!result.Success)
            {
                return BadRequest(result?.Message);
            }
            return Ok(result.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error 500 in {nameof(UserController)}, method: {nameof(CreateUser)}");
            return BadRequest(ex.Message);
        }
    }

    [HttpGet(GET_ALL_ROUTE)]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public async Task<ActionResult> GetAllUsers()
    {
        try
        {
            var result = await _userService.GetAllUsersAsync();

            if (!result.Success)
            {
                return BadRequest(result?.Message);
            }

            return Ok(result.Value);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error 500 in {nameof(UserController)}, method: {nameof(GetAllUsers)}");
            return BadRequest(ex.Message);
        }
    }

    [HttpGet(GET_ROUTE)]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public async Task<ActionResult> GetUser(int id)
    {
        try
        {
            var result = await _userService.GetUserByIdAsync(id);
            return Ok(result.Value);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error 500 in {nameof(UserController)}, method: {nameof(GetUser)}");
            return BadRequest(ex.Message);
        }
    }
}
