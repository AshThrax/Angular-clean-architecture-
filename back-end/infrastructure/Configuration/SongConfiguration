using Domain.Entity;
using Microsoft.EntityframeworkCore;
using Microsoft.EntityframeworkCore.Metadata.Builders;

public class SongConfiguration : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.Property(t => t.Title).IsRequired();
    }
}