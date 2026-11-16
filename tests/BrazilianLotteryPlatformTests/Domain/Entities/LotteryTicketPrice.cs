namespace BrazilianLotteryPlatform.Domain.Entities;

/// <summary>
/// Represents the ticket price for a specific number of selected numbers.
/// </summary>
public class LotteryTicketPrice
{
    /// <summary>
    /// The number of selected numbers in the ticket.
    /// </summary>
    public int Numbers { get; init; }

    /// <summary>
    /// The ticket price in Brazilian reais.
    /// </summary>
    public decimal Price { get; init; }
}