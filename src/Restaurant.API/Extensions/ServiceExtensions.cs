using Restaurant.BLL.Contracts;
using Restaurant.BLL.Services;
using Restaurant.BLL.Utilities;
using Restaurant.DAL;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Repository;

namespace Restaurant.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection serviceCollection) =>
        serviceCollection.AddDbContext<ApplicationContext>();

    public static void ConfigureMapper(this IServiceCollection serviceCollection) =>
        serviceCollection.AddAutoMapper(typeof(AutoMapperProfile));

    public static void ConfigureRepositoryManager(this IServiceCollection serviceCollection) =>
        serviceCollection.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureServiceManager(this IServiceCollection serviceCollection) =>
        serviceCollection.AddScoped<IServiceManager, ServiceManager>();
}