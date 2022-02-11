using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(e => e.ArtistId);
            builder.Property(e => e.Name).HasMaxLength(255);
            builder.Property(e => e.DateOfBirth).IsRequired();
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Phone).IsRequired();
            builder.Property(e => e.InstagramUrl).IsRequired();
            builder.HasOne(e => e.Song)
                .WithMany(p => p.Artists)
                .HasForeignKey(e => e.A)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
