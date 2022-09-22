using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class ReviewMapping : IEntityTypeConfiguration<ReviewEntity>
    {
        public void Configure(EntityTypeBuilder<ReviewEntity> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ListingId).IsRequired();
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.ReviewerId).IsRequired();
            builder.Property(p => p.ReviewerName).IsRequired();
            builder.Property(p => p.Comments).IsRequired();
        }
    }
}