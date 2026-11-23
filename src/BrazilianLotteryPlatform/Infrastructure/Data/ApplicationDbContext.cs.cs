
using BrazilianLotteryPlatform.Domain.Entities;
using BrazilianLotteryPlatform.Infrastructure.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace BrazilianLotteryPlatform.Infrastructure.Data;

/// <summary>
/// Represents the application's database context.
/// </summary>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    /// <summary>
    /// Gets the lottery configurations.
    /// </summary>
    public DbSet<LotteryConfig> LotteryConfigs => Set<LotteryConfig>();

    /// <summary>
    /// Applies entity configurations.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        LotteryConfigSeed.Configure(modelBuilder);
    }
}
