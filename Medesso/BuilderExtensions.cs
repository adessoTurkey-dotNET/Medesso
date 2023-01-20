using System.Reflection;
using Medesso.Mediator;
using Medesso.Processor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Medesso;

public static class BuilderExtensions
{
    public static IServiceCollection AddMedesso(this IServiceCollection services, params Assembly[] assemblies)
    {
        AddRequiredServices(services);
        RegisterServices(services, assemblies, typeof(IMedessoRequestHandler<,>));

        return services;
    }  
        
    private static IServiceCollection RegisterServices(this IServiceCollection services, Assembly[] assemblies, Type registerationObj)
    {
        foreach (var assembly in assemblies)
        {
            var types = assembly.GetTypes();
            var handlers = types.Where(x => x.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == registerationObj));
            foreach (var handle in handlers)
            {
                var interfaces = handle.GetInterfaces();
                foreach (var handleInterface in interfaces)
                {
                    services.AddTransient(handleInterface, handle);
                }
            }
        }
        
        return services;
    }
        
    private static void AddRequiredServices(IServiceCollection services)
    {
        services.TryAdd(new ServiceDescriptor(typeof(IMedessoMediator), typeof(MedessoMediator), ServiceLifetime.Transient));

        services.AddScoped(typeof(IMedessoPipelineBehavior<,>), typeof(MedessoRequestPreProcessorBehavior<,>));
        services.AddScoped(typeof(IMedessoPipelineBehavior<,>), typeof(MedessoRequestPostProcessorBehavior<,>));
    }
}