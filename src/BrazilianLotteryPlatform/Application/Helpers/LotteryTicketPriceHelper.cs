using BrazilianLotteryPlatform.Domain.ValueObjects;
using System.Collections.Generic;

namespace BrazilianLotteryPlatform.Application.Helpers;

/// <summary>
/// Provides helper methods for generating lottery ticket prices.
/// </summary>
public static class LotteryTicketPriceHelper
{
    /// <summary>
    /// Generates ticket prices for all supported ticket sizes.
    /// </summary>
    public static IReadOnlyList<LotteryTicketPrice> GeneratePrices(
        int minNumbersPerGame,
        int maxNumbersPerGame,
        decimal basePrice)
    {
        var prices = new List<LotteryTicketPrice>();

        for (var numbers = minNumbersPerGame; numbers <= maxNumbersPerGame; numbers++)
        {
            prices.Add(new LotteryTicketPrice(numbers, CalculatePrice(numbers, minNumbersPerGame, basePrice)));
        }

        return prices;
    }

    private static decimal CalculatePrice(int numbers, int numbersPerGame, decimal basePrice)
    {
        long combinations = 1;

        for (int i = 1; i <= numbersPerGame; i++)
        {
            combinations = combinations * (numbers - i + 1) / i;
        }

        return combinations * basePrice;
    }
}