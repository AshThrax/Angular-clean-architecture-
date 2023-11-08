using Domain.Entity;
using Microsoft.EntityframeworkCore;
using Microsoft.EntityframeworkCore.Metadata.Builders;

public class AlbumConfiguration : IEntityConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.Property(t => t.Title).IsRequired();
    }
}