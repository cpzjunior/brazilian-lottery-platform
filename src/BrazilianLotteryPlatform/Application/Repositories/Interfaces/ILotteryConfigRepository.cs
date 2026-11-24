
using BrazilianLotteryPlatform.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BrazilianLotteryPlatform.Application.Repositories.Interfaces;

/// <summary>
/// Defines persistence operations for lottery configurations.
/// </summary>
public interface ILotteryConfigRepository
{
    /// <summary>
    /// Retrieves all lottery configurations.
    /// </summary>
    Task<IReadOnlyList<LotteryConfig>> List(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a lottery configuration by its identifier.
    /// </summary>
    Task<LotteryConfig> GetById(
        string id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a lottery configuration.
    /// </summary>
    Task Add(
        LotteryConfig lotteryConfig,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a lottery configuration.
    /// </summary>
    Task Update(
        LotteryConfig lotteryConfig,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a lottery configuration.
    /// </summary>
    Task Delete(
        string id,
        CancellationToken cancellationToken = default);
}
