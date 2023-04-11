using MediatR.Extensions.FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using SharedKernel.Application;

namespace SanPham.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddSanPhamApplicationServices(this IServiceCollection services)
    {
        services.AddSharedKernelApplicationServices();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddFluentValidation(new[] { Assembly.GetExecutingAssembly() });
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.Configure<ApiBehaviorOptions>(options => options.SuppressInferBindingSourcesForParameters = true);
        return services;
    }
}