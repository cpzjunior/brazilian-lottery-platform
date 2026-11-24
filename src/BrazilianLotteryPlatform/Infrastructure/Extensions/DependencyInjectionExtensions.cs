
using BrazilianLotteryPlatform.Application.Repositories.Interfaces;
using BrazilianLotteryPlatform.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BrazilianLotteryPlatform.Infrastructure.Extensions;

/// <summary>
/// Provides extension methods for dependency injection configuration.
/// </summary>
public static class DependencyInjectionExtensions
{
    /// <summary>
    /// Registers infrastructure dependencies.
    /// </summary>
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<ILotteryConfigRepository, LotteryConfigRepository>();

        return services;
    }
}
