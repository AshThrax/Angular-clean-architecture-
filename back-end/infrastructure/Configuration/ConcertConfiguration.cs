using Domain.Entity;
using Microsoft.EntityframeworkCore;
using Microsoft.EntityframeworkCore.Metadata.Builders;

public class ConcertConfiguration : IEntityConfiguration<Concert>
{
    public void Configure(EntityTypebuilder<Concert> builder)
    {
        builder.Property(t => t.Title).IsRequired();
    }
}