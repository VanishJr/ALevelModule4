using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Module4
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {    
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(e => e.GenreId);
            builder.Property(e => e.Title).HasMaxLength(255);
            builder.HasMany(e => e.Genres)
                .WithOne(p => p.Song)
                .HasForeignKey(e => e.SongId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(e => e.Duration).IsRequired();
            builder.HasOne(e => e.Artist)
                .WithMany(p => p.Songs)
                .HasForeignKey(e => e.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Song)
                .WithMany(p => p.Genres)
                .HasForeignKey(e => e.SongId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}