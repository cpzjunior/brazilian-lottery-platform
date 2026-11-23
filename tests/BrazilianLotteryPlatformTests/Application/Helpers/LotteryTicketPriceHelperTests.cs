using BrazilianLotteryPlatform.Application.Helpers;
using BrazilianLotteryPlatform.Domain.ValueObjects;

namespace BrazilianLotteryPlatformTests.Application.Helpers
{
    /// <summary>
    /// Contains unit tests for LotteryTicketPriceHelper.
    /// </summary>
    public class LotteryTicketPriceHelperTests
    {
        /// <summary>
        /// Verifies that Mega-Sena ticket prices are generated correctly.
        /// </summary>
        [Fact]
        public void GeneratePrices_MegaSena_ReturnsExpectedPrices()
        {
            // Arrange
            var expectedPrices = new List<LotteryTicketPrice>
        {
            new(6, 6.00m),
            new(7, 42.00m),
            new(8, 168.00m),
            new(9, 504.00m),
            new(10, 1260.00m),
            new(11, 2772.00m),
            new(12, 5544.00m),
            new(13, 10296.00m),
            new(14, 18018.00m),
            new(15, 30030.00m),
            new(16, 48048.00m),
            new(17, 74256.00m),
            new(18, 111384.00m),
            new(19, 162792.00m),
            new(20, 232560.00m)
        };

            // Act
            var actualPrices = LotteryTicketPriceHelper.GeneratePrices(
                minNumbersPerGame: 6,
                maxNumbersPerGame: 20,
                basePrice: 6.00m);

            // Assert
            Assert.Equal(expectedPrices, actualPrices);
        }
    }
}