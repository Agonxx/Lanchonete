using Lanchonete.API.Database;
using Lanchonete.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.OpenApi.Models;

namespace Lanchonete.API.Utils
{
    public static class ConfigApi
    {
        public static IServiceCollection SetupRepositories(this IServiceCollection services)
        {
            services.AddScoped<PedidoRepository>();
            services.AddScoped<CaixaRepository>();
            services.AddScoped<ProdutoRepository>();

            return services;
        }
        public static IServiceCollection SetupDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConexaoDB");

            services.AddDbContext<DBLanchonete>(options =>
                options.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .ConfigureWarnings(warnings =>
                    warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));

            return services;
        }

        public static IServiceCollection SetupSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Lanchonete API",
                    Version = "v1",
                    Description = "API para lanchonete"
                });
            });

            return services;
        }

        public static IServiceCollection SetupCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            return services;
        }
    }
}
