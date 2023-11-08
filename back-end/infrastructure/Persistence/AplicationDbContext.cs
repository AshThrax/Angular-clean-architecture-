using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using System.Reflection;
using Domain.Entity;

public class ApplicationDbContext : DbContext,IApplicationDbContext
{

    ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
    {

    }

    public DbSet<Song> Song{ get; set;}
    public DbSet<Concert> Concert { get; set; }
    public DbSet<Album> Album { get; set; }

    protected Task<int> SavechangesAsync(CancellationToken cancellationToken =new CancellationToken())
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
