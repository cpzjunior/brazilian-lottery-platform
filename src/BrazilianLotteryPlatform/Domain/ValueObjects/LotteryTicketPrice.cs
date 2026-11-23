namespace BrazilianLotteryPlatform.Domain.ValueObjects;

/// <summary>
/// Represents the price associated with a lottery ticket size.
/// </summary>
public record LotteryTicketPrice(int Numbers, decimal Price);