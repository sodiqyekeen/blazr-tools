using Blazr.Tools.ServiceImplementations;
using Blazr.Tools.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazr.Tools
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBlazrToolsServices(this IServiceCollection services)
        {
            services.AddScoped<IClipboardService, ClipboardService>();
            return services;
        }
    }
}
