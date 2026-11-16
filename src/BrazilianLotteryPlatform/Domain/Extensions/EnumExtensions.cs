using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace BrazilianLotteryPlatform.Domain.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Gets the display name defined by the Display attribute.
    /// Falls back to the enum member name when the attribute is not present.
    /// </summary>
    public static string GetDisplayName(this Enum value)
    {
        var member = value.GetType().GetMember(value.ToString()).FirstOrDefault();

        return member?
            .GetCustomAttribute<DisplayAttribute>()?
            .GetName() ?? value.ToString();
    }
}
