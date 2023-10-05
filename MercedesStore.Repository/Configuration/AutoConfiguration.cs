using MercedesStore.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MercedesStore.Repository.Configuration
{
    public class AutoConfiguration : IEntityTypeConfiguration<Auto>
    {
        public void Configure(EntityTypeBuilder<Auto> builder)
        {
            builder.Property(c=>c.AutoId)
                .ValueGeneratedOnAdd();
        }
    }
}
