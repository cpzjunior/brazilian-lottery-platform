
namespace BrazilianLotteryPlatform.Application.Common.Results;

/// <summary>
/// Represents the result of an operation.
/// </summary>
public class Result<T>
{
    public T Value { get; }
    public Error Error { get; }
    public bool IsSuccess => Error is null;

    private Result(T value, Error error)
    {
        Value = value;
        Error = error;
    }

    public static Result<T> Success(T value) =>
        new(value, null);

    public static Result<T> Failure(Error error) =>
        new(default, error);
}
