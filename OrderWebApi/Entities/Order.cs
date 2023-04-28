using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OrderWebApi.Entities
{
    [Serializable, BsonIgnoreExtraElements]
    public class Order:Entity
    {
       

        [BsonElement("customer_id"), BsonRepresentation(BsonType.Int32)]
        public int CustomerId { get; set; }

        [BsonElement("ordered_on"), BsonRepresentation(BsonType.DateTime)]
        public DateTime OrderedOn { get; set; }

        [BsonElement("order_details")]
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
