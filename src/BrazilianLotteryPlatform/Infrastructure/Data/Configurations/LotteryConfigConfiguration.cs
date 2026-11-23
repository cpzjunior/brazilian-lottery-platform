
using BrazilianLotteryPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrazilianLotteryPlatform.Infrastructure.Data.Configurations;

/// <summary>
/// Configures the LotteryConfig entity.
/// </summary>
public class LotteryConfigConfiguration : IEntityTypeConfiguration<LotteryConfig>
{
    public void Configure(EntityTypeBuilder<LotteryConfig> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired();
    }
}
