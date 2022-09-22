using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class CalendarMapping : IEntityTypeConfiguration<CalendarEntity>
    {
        public void Configure(EntityTypeBuilder<CalendarEntity> builder)
        {
            builder.ToTable("Calendars");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ListingId).IsRequired();
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.Price).IsRequired();
        }
    }
}