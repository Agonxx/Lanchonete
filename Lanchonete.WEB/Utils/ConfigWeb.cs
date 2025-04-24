namespace Lanchonete.WEB.Utils
{
    public static class ConfigWeb
    {
        public static IServiceCollection SetupServices(this IServiceCollection services)
        {
            //services.AddScoped<IUsuarioRestService, UsuarioRestService>();

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
