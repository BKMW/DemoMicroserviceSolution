using Microsoft.Extensions.Options;
using MongoDB.Driver;
using OrderWebApi.Dtos;
using OrderWebApi.Entities;

namespace OrderWebApi.Data
{
    public class Context : IContext
    {
        public Context(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);

            Orders = mongoDatabase.GetCollection<Order>(databaseSettings.Value.CollectionName);
           //rders.Indexes.CreateManyAsync(new[] { new CreateIndexModel<Order>(Builders<Order>.IndexKeys.Geo2DSphere(it => it.OrderDetails)) });
        }

        public IMongoCollection<Order> Orders { get; }
    }
}
