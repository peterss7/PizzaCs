using Microsoft.AspNetCore.Http;

namespace PizzaCs.Core.Models.Errors;

public sealed record PizzaError(string Code, string Message)
{
    public static readonly PizzaError InvalidInput = new(StatusCodes.Status400BadRequest.ToString(), "Input is invalid.");
    public static readonly PizzaError NotFound = new(StatusCodes.Status404NotFound.ToString(), "404: Not Found.");
    public static readonly PizzaError InternalServerError = new(StatusCodes.Status500InternalServerError.ToString(), "500: Internal Server Error");
}
