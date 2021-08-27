using FileTypeExample.Application.Interfaces;
using FileTypeExample.Application.Services;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Infrastructure.Context;
using FileTypeExample.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FileTypeExample.Application.Dependency
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterFileType(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FileTypeExampleDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBigParaRepository, BigParaRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IAdvRepository, AdvRepository>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<IDatabaseService, DatabaseService>();

            services.AddMemoryCache();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
