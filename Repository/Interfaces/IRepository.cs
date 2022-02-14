using System;
using System.Linq;

namespace API_MongoDb_CosmoDb.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> QueryAll();

        T Query(Guid key);
        void Insert(T obj);
    }
}
