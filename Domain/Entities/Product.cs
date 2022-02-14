using MongoDB.Bson.Serialization.Attributes;

namespace API_MongoDb_CosmoDb.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Product : Base.BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
