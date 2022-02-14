namespace API_MongoDb_CosmoDb.Domain.Base
{
    using Domain.Interfaces;
    using System;

    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Key { get; set; }

        protected BaseEntity() =>
            this.Key = Guid.NewGuid();

    }
}
