
using BrazilianLotteryPlatform.Domain.Enums;
using BrazilianLotteryPlatform.Domain.Extensions;

namespace BrazilianLotteryPlatformTests.Domain.Extensions;

public class EnumExtensionsTests
{
    [Fact]
    public void GetDisplayName_ShouldReturnDisplayName_WhenAttributeExists()
    {
        // Act
        var result = LotteryType.MegaSena.GetDisplayName();

        // Assert
        Assert.Equal("Mega-Sena", result);
    }

    [Fact]
    public void GetDisplayName_ShouldReturnEnumName_WhenAttributeDoesNotExist()
    {
        // Arrange
        var value = TestEnum.WithoutDisplay;

        // Act
        var result = value.GetDisplayName();

        // Assert
        Assert.Equal("WithoutDisplay", result);
    }

    private enum TestEnum
    {
        WithoutDisplay
    }
}
