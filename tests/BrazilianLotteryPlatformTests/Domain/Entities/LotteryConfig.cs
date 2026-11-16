namespace BrazilianLotteryPlatform.Domain.Entities;

/// <summary>
/// Represents the configuration of a lottery.
/// </summary>
public class LotteryConfig
{
    /// <summary>
    /// The lottery's name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// How many numbers are drawn in each game.
    /// </summary>
    public int NumbersPerGame { get; init; }

    /// <summary>
    /// The minimum value that can be drawn in the lottery.
    /// </summary>
    public int MinValue { get; init; }

    /// <summary>
    /// The maximum value that can be drawn in the lottery.
    /// </summary>
    public int MaxValue { get; init; }

    /// <summary>
    /// The ticket prices according to the number of selected numbers.
    /// </summary>
    public required List<LotteryTicketPrice> TicketPrices { get; init; }
}