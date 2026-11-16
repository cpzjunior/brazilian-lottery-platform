
using BrazilianLotteryPlatform.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BrazilianLotteryPlatformTests.Controllers;

public class LotteryControllerTests
{
    private readonly LotteryController _controller;

    public LotteryControllerTests()
    {
        _controller = new LotteryController();
    }

    [Fact]
    public void GetLotteryTypes_ShouldReturnOk()
    {
        // Act
        var result = _controller.GetLotteryTypes();

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void GetLotteryTypes_ShouldReturnAvailableLotteryTypes()
    {
        // Act
        var result = _controller.GetLotteryTypes();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var lotteryTypes = Assert.IsType<string[]>(okResult.Value);

        Assert.Single(lotteryTypes);
        Assert.Equal("megasena", lotteryTypes[0]);
    }
}
