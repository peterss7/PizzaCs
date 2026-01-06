using PizzaCs.Core.Models.Errors;

namespace PizzaCs.Infrastructure.Models.Errors;

public class PizzaResult
{
    public bool Success { get; set; } = false;
    public string? Message { get; set; }
    public List<PizzaError> Errors { get; set; } = new List<PizzaError>();

    public void AddError(PizzaError error, string? message = null)
    {
        Errors.Add(error);
        Message = message ?? Message;
    }

    public PizzaResult Ok(string? message = null)
    {
        Success = true;
        Message = message ?? Message;
        return this;
    }
}

public class PizzaResult<T> : PizzaResult
{
    public T? Value { get; set; }

    public PizzaResult() { }

    public static PizzaResult<T> Ok(T? value, string? message) =>
        new PizzaResult<T> { Success = true, Value = value, Message = !string.IsNullOrEmpty(message) ? message : "Success."};

    public static PizzaResult<T> Fail(PizzaError error, string? message = null) =>
        new PizzaResult<T> { Success = false, Errors = new List<PizzaError>{ error }, Message = message ?? "Failure."};

}
