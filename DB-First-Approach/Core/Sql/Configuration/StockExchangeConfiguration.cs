using Core.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Sql.Configuration;

public class StockExchangeConfiguration : IEntityTypeConfiguration<StockExchangeEntity>
{
    public void Configure(EntityTypeBuilder<StockExchangeEntity> builder)
    {
        builder
              .ToTable("StocksExchange")
              .HasKey(e => e.ExchangeId)
              .HasName("Pk_ExchangeId");
        builder
            .Property(e => e.ExchangeId)
            .ValueGeneratedOnAdd()
            .HasColumnName("ExchangeId");
    }
}
