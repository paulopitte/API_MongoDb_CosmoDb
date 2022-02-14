
namespace API_MongoDb_CosmoDb.Repository.Context
{
    using MongoDB.Driver;

    public interface IConnectionFactory
    {
        IMongoClient GetClient();

        IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName);

        IMongoDatabase GetDatabase(string databaseName);
    }



    public sealed class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IMongoClient GetClient()
        {
            return new MongoClient(_connectionString);
        }

        public IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName)
        {
            return mongoClient.GetDatabase(databaseName);
        }

        public IMongoDatabase GetDatabase(string databaseName)
        {
            var mongoDbClient = GetClient();

            return mongoDbClient.GetDatabase(databaseName);
        }
    }
}
