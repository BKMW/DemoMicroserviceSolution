using MongoDB.Driver;
using OrderWebApi.Entities;

namespace OrderWebApi.Data
{
    public interface IContext
    {
        IMongoCollection<Order> Orders { get; }
    }
}
