using SharedKernel.Api;
using SanPham.Application;
using SanPham.Infrastructure;
using Microsoft.OpenApi.Models;

namespace SanPham.Api
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddSanPhamApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionStr = configuration.GetConnectionString("default");
            var connectionStrLog = configuration.GetConnectionString("log_context");
            services.AddSharedKernelApiServices();
            services.AddSanPhamApplicationServices();
            services.AddSanPhamInfrastructureServices(connectionStr, connectionStrLog);
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
               {
                 new OpenApiSecurityScheme
                 {
                   Reference = new OpenApiReference
                   {
                     Type = ReferenceType.SecurityScheme,
                     Id = "Bearer"
                   }
                  },
                  new string[] { }
                }
              });
            });
            return services;
        }
    }
}
