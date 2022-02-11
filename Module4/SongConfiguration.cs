using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(e => e.SongId);
            builder.Property(e => e.Title).HasMaxLength(255);
            builder.Property(e => e.RealeseDate).IsRequired();
            builder.Property(e => e.Duration).IsRequired();
            builder.HasOne(e => e.Artist)
                .WithMany(p => p.Song)
                .HasForeignKey(e => e.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Genre)
                .WithMany(p => p.Genres)
                .HasForeignKey(e => e.SongId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Songs)
                .WithMany(p => p.)
                .HasForeignKey(e => e.A)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}