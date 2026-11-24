
namespace BrazilianLotteryPlatform.Application.Common.Results;

/// <summary>
/// Represents the result of an operation without a return value.
/// </summary>
public class ResultEmpty
{
    public Error Error { get; }
    public bool IsSuccess => Error is null;

    private ResultEmpty(Error error)
    {
        Error = error;
    }

    public static ResultEmpty Success() =>
        new(null);

    public static ResultEmpty Failure(Error error) =>
        new(error);
}
