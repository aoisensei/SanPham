using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SanPham.Application.Interfaces;
using SanPham.Infrastructure.Data;
using SharedKernel.Infrastructure;
using System.Reflection;

namespace SanPham.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddSanPhamInfrastructureServices(this IServiceCollection services, string connectionStr, string connectionStrLog)
    {
        services.AddSharedKernelInfrastructureServices(connectionStrLog);
        services.AddDbContext<SanPhamDbContext>
            (builder =>
            builder.UseSqlServer(connectionStr,
            sql => sql.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
            );

        services.AddScoped<ISanPhamDbContext>(provider => provider.GetRequiredService<SanPhamDbContext>());
        services.AddScoped<SanPhamDbContextInitial>();

        return services;
    }
}