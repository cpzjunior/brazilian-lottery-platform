using BrazilianLotteryPlatform.Domain.Enums;
using BrazilianLotteryPlatform.Domain.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BrazilianLotteryPlatform.Controllers;

[ApiController]
[Route("api/lottery")]
public class LotteryController : ControllerBase
{
    /// <summary>
    /// Retrieves the available lottery types.
    /// </summary>
    [HttpGet("type")]
    public IActionResult GetLotteryTypes()
    {
        var lotteryTypes = Enum.GetValues<LotteryType>()
            .Select(type => type.GetDisplayName())
            .ToArray();

        return Ok(lotteryTypes);
    }
}
