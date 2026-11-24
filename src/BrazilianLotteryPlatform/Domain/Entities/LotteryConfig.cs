namespace BrazilianLotteryPlatform.Domain.Entities;

/// <summary>
/// Represents the configuration of a lottery.
/// </summary>
public class LotteryConfig
{
    /// <summary>
    /// The unique identifier of the lottery configuration.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The lottery's name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The minimum number of numbers drawn in each game.
    /// </summary>
    public int MinNumbersPerGame { get; init; }

    /// <summary>
    /// The maximum number of numbers drawn in each game.
    /// </summary>
    public int MaxNumbersPerGame { get; init; }

    /// <summary>
    /// The minimum value that can be drawn in the lottery.
    /// </summary>
    public int MinValue { get; init; }

    /// <summary>
    /// The maximum value that can be drawn in the lottery.
    /// </summary>
    public int MaxValue { get; init; }

    /// <summary>
    /// Gets the price of a standard ticket with the minimum number of selected numbers.
    /// </summary>
    public decimal BasePrice { get; init; }
}
