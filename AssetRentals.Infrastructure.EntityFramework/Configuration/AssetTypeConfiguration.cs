using AssetRentals.Core.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetRentals.Infrastructure.EntityFramework.Configuration
{
    public class AssetTypeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.ToTable("AssetTypes");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property<DateTime>("RecordCreatedDate").IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property<DateTime?>("RecordLastUpdatedDate");
        }
    }
}
