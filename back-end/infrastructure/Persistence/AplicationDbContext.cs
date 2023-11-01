using Microsoft.EntityframeworkCore;
public class ApplicationDbContext : DbContext
{

    ApplicationDbContext(ApplicationDbContext<Option> context) : base(context)
    {

    }

    DbSet<Song> Song{ get; set;}
    DbSet<Concert> Concert { get; set; }
    DbSet<Album> Album { get; set; }

    protected Task<int> Savechanges
}