using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class ListingMapping : IEntityTypeConfiguration<ListingEntity>
    {
        public void Configure(EntityTypeBuilder<ListingEntity> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.ListingUrl).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.PropertyType).IsRequired();
        }
    }
}