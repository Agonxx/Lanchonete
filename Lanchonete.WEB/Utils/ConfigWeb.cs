using Lanchonete.WEB.Services;
using Lanchonete.WEB.Services.Interfaces;

namespace Lanchonete.WEB.Utils
{
    public static class ConfigWeb
    {
        public static IServiceCollection SetupServices(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<HttpClientService>();

            return services;
        }

        public static IServiceCollection SetupApis(this IServiceCollection services, IConfiguration configuration, string urlApi)
        {
            services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(urlApi)
            });

            return services;
        }

    }
}
