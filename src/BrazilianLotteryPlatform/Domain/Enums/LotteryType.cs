using System.ComponentModel.DataAnnotations;

namespace BrazilianLotteryPlatform.Domain.Enums;

public enum LotteryType
{
    /// <summary>
    /// Mega-Sena lottery.
    /// </summary>
    [Display(Name = "megasena")]
    MegaSena
}