using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace API_MongoDb_CosmoDb.Middlewares
{
    using Domain.Entities;
    using Repository;
    using Repository.Context;
    using Repository.Interfaces;
    using Services;

    public static class DependencyInjectionMiddleware
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDbSettings = configuration.GetSection("MongoDBSetting").Get<MongoDBSetting>();

            var connectionFactory = new ConnectionFactory(mongoDbSettings.ConnectionString);

            services.AddSingleton<IRepository<Product>>(
                p => new ProductRepository(connectionFactory, mongoDbSettings.DatabaseName,
                    mongoDbSettings.CollectionName));

            services.AddTransient<IProductServices, ProductServices>();
        }
    }
}
