
using BrazilianLotteryPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrazilianLotteryPlatform.Infrastructure.Data.Seeds;

/// <summary>
/// Defines the initial lottery configuration data.
/// </summary>
public static class LotteryConfigSeed
{
    /// <summary>
    /// Adds the initial Mega-Sena configuration and ticket prices.
    /// </summary>
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LotteryConfig>().HasData(
            new LotteryConfig
            {
                Id = "megasena",
                Name = "Mega-Sena",
                MinNumbersPerGame = 6,
                MaxNumbersPerGame = 20,
                MinValue = 1,
                MaxValue = 60,
                BasePrice = 6.00m,
            });
    }
}
