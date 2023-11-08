using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public static class DependencyInjection
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection service,IConfiguration configuration)
    {
        service.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
        );
        service.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        return service;
    }
}
