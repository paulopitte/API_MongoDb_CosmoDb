
using System.Linq;
using System;

namespace API_MongoDb_CosmoDb.Repository.Base
{
    using Repository.Interfaces;
    using Domain.Interfaces;
    using Repository.Context;
    using MongoDB.Driver;

    public abstract class Repository<T> : IRepository<T> where T : IBaseEntity
    {
        private readonly IMongoCollection<T> _collectionName;

        protected Repository(IMongoCollection<T> collectionName)
        {
            _collectionName = collectionName;
        }

        protected Repository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
        {
            _collectionName = connectionFactory.GetDatabase(databaseName).GetCollection<T>(collectionName);
        }

        public IQueryable<T> QueryAll()
        {
            return _collectionName.AsQueryable<T>();
        }

        public T Query(Guid key)
        {
            return _collectionName.AsQueryable<T>().FirstOrDefault(w => w.Key == key);
        }

        public void Insert(T obj)
        {
            _collectionName.InsertOne(obj);
        }
    }
}
