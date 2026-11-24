using BrazilianLotteryPlatform.Domain.Enums;
using BrazilianLotteryPlatform.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BrazilianLotteryPlatform.Infrastructure.Extensions;

/// <summary>
/// Provides extension methods for database configuration.
/// </summary>
public static class DatabaseExtensions
{
    /// <summary>
    /// Configuration key used to identify the database provider.
    /// </summary>
    private const string DATABASE_PROVIDER_KEY = "Database:Provider";

    /// <summary>
    /// Name of the database connection string.
    /// </summary>
    private const string CONNECTION_STRING_NAME = "BrazilianLotteryPlatform";

    /// <summary>
    /// Name of the in-memory database.
    /// </summary>
    private const string INMEMORY_DATABASE_NAME = "BrazilianLotteryPlatform";

    /// <summary>
    /// Registers the configured database provider.
    /// </summary>
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var provider = Enum.Parse<DatabaseProviderType>(
            configuration[DATABASE_PROVIDER_KEY] ?? nameof(DatabaseProviderType.SQLite),
            ignoreCase: true);

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            switch (provider)
            {
                case DatabaseProviderType.SQLite:
                    options.UseSqlite(
                        configuration.GetConnectionString(CONNECTION_STRING_NAME));
                    break;

                case DatabaseProviderType.InMemory:
                    options.UseInMemoryDatabase(INMEMORY_DATABASE_NAME);
                    break;

                default:
                    throw new NotSupportedException($"Database provider '{provider}' is not supported.");
            }
        });

        return services;
    }
}