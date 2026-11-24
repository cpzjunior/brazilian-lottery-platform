
using BrazilianLotteryPlatform.Application.Repositories.Interfaces;
using BrazilianLotteryPlatform.Domain.Entities;
using BrazilianLotteryPlatform.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BrazilianLotteryPlatform.Infrastructure.Repositories;

/// <summary>
/// Implements persistence operations for lottery configurations.
/// </summary>
public class LotteryConfigRepository(ApplicationDbContext context)
    : ILotteryConfigRepository
{
    /// <inheritdoc />
    public async Task<IReadOnlyList<LotteryConfig>> List(
        CancellationToken cancellationToken = default)
    {
        return await context.LotteryConfigs
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LotteryConfig> GetById(
        string id,
        CancellationToken cancellationToken = default)
    {
        return await context.LotteryConfigs
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    /// <inheritdoc />
    public async Task Add(
        LotteryConfig lotteryConfig,
        CancellationToken cancellationToken = default)
    {
        await context.LotteryConfigs.AddAsync(lotteryConfig, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task Update(
        LotteryConfig lotteryConfig,
        CancellationToken cancellationToken = default)
    {
        context.LotteryConfigs.Update(lotteryConfig);
        await context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task Delete(
        string id,
        CancellationToken cancellationToken = default)
    {
        var lotteryConfig = await context.LotteryConfigs
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (lotteryConfig is null)
            return;

        context.LotteryConfigs.Remove(lotteryConfig);
        await context.SaveChangesAsync(cancellationToken);
    }
}
