using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CentralPeer.Application;

public static class DependencyInjection
{
    /// <summary>
    ///  scan application layer for all incoming commands and queries
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}