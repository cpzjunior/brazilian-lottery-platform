
namespace BrazilianLotteryPlatform.Domain.Enums;

/// <summary>
/// Defines the supported database providers.
/// </summary>
public enum DatabaseProviderType
{
    /// <summary>
    /// Uses SQLite for persistent storage.
    /// </summary>
    SQLite,

    /// <summary>
    /// Uses an in-memory database.
    /// </summary>
    InMemory
}
