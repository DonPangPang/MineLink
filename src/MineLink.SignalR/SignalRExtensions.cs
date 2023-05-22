using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MineLink.SignalR;

public static class SignalRExtensions
{
    public static IServiceCollection AddSignalRServer(this IServiceCollection services)
    {
        services.AddSignalR();

        return services;
    }

    public static WebApplication UseSignalR(this WebApplication app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<RecordHub>();
        });

        return app;
    }
}