using Microsoft.AspNetCore.Mvc;
using PizzaCs.Core.Models.Dtos.Users;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Core.Utilities.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Models.Errors;

namespace PizzacCs.Api.Controllers;

[Route(API_ROUTE)]
[ApiController]
public class UserController : Controller
{
    public const string API_ROUTE = "api/users";
    public const string GET_ROUTE = "get";
    public const string CREATE_ROUTE = "create";

    private readonly ILogger<UserController> _logger;
    private readonly IBaseService<UserEfc, UserDto> _userService;

    public UserController(
        ILogger<UserController> logger,
        IBaseService<UserEfc, UserDto> userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet(GET_ROUTE)]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public async Task<IActionResult> GetUser(int id)
    {
        try
        {
            return Ok("Ok, got user");
        }
        catch (Exception ex)
        {
            _logger.LogError("Error getting user...", ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost(CREATE_ROUTE)]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<UserEfc>> CreateUser([FromForm] UserDto userDto)
    {
        try
        {
            UserDto? result = await _userService.CreateAsync(userDto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError("Error creating user...", ex.Message);
            return BadRequest(ex.Message);
        }
    }
}
