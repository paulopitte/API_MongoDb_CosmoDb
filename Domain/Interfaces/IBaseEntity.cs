using System;

namespace API_MongoDb_CosmoDb.Domain.Interfaces
{
    public interface IBaseEntity
    {
        Guid Key { get; set; }
    }
}
