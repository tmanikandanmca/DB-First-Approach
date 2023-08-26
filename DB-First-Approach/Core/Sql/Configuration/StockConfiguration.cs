using Core.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sql.Configuration;

internal class StockConfiguration : IEntityTypeConfiguration<StocksEntity>
{
    public void Configure(EntityTypeBuilder<StocksEntity> builder)
    {
        builder
           .ToTable("Stocks")
           .HasKey(e => e.Id)
           .HasName("pk_SId");
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("SId");
        //builder
        //    .HasOne(e => e.Exchange)
        //    .WithMany(e => e.Stocks)
        //    .HasForeignKey("ExchangeId")
        //    .HasConstraintName("FK_Stocks_ExchangeId")
        //    .IsRequired();
    }
}
