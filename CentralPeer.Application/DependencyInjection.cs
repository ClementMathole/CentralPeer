using Microsoft.Extensions.DependencyInjection;

namespace CentralPeer.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // register application layer services here
        return services;
    }
}