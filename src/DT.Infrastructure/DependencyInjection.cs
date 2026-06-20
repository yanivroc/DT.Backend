using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DT.Application.Interfaces;
using DT.Infrastructure.Persistence;
using DT.Infrastructure.Repositories;

namespace DT.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration cfg)
    {
        var cs = cfg.GetConnectionString("Default")
            ?? throw new InvalidOperationException("ConnectionStrings:Default missing");
        services.AddDbContext<AppDbContext>(o =>
            o.UseMySql(cs, ServerVersion.AutoDetect(cs)));
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddSingleton<IDapperReader, DapperReader>();
        return services;
    }
}
