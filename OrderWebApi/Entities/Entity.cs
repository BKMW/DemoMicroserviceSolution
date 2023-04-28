using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace OrderWebApi.Entities
{
    public class Entity
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
         public string Id { get; set; }
    }
}
