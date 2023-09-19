using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using System.Runtime.CompilerServices;

namespace Qwips.Core.MultiCase
{
    public static class MultiCaseStartup
    {
        public static IServiceCollection AddMultiCaseClient(this IServiceCollection services)
        {
            ConfigureServices(services);
            return services;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAuthenticationProvider, BasicAuthorizationProvider>();
            services.AddTransient<IMultiCaseClient, MultiCaseClient>();
            services.AddTransient<IRequestAdapter, Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter>(implementation =>
            {
                var provider = implementation.GetService<IAuthenticationProvider>();
                return new Microsoft.Kiota.Http.HttpClientLibrary.HttpClientRequestAdapter(provider);
            });
        }
    }
}
