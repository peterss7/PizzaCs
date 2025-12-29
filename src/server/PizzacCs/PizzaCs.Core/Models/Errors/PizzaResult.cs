namespace PizzaCs.Infrastructure.Models.Errors;

public class PizzaResult<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public PizzaResult() { }

    public static PizzaResult<T> Ok(T? data, string? message) =>
        new PizzaResult<T> { Success = true, Data = data, Message = message };

    public static PizzaResult<T> Fail(T? data, string? message) =>
        new PizzaResult<T> { Success = false, Data = data, Message = message };

}
