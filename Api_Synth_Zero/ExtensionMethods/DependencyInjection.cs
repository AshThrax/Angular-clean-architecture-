using Application;
using Infrastructure;
namespace Api_Synth_Zero.ExtensionMethods
{
    public static class DependencyInjection
    {
        public static IServiceCollection DI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddApplication();
            service.AddInfrastructure(configuration);
            return service;
        }
    }
}
