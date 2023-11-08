using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        //ajout AutoMappeur
        service.AddAutoMapper(Assembly.GetExecutingAssembly());
        //ajout des validateur
        service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //ajout mediateur
        //mediateur 12.0.1
        service.AddMediatR(Cfg=>Cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return service;
    }
}
