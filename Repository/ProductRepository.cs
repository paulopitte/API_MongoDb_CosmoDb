
namespace API_MongoDb_CosmoDb.Repository
{
    using Domain.Entities;
    using Repository.Context;
    using Repository.Base;
    using MongoDB.Driver;

    public sealed class ProductRepository : Repository<Product>
    {
        public ProductRepository(IMongoCollection<Product> collectionName) : base(collectionName)
        {
        }

        public ProductRepository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
            : base(connectionFactory, databaseName, collectionName)
        {
        }
    }
}
