using MongoDB.Driver;
using OrderWebApi.Entities;

namespace OrderWebApi.Data
{
    public class MongoRepository<T> : IRepository<T> where T : Entity
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepository(IMongoClient client, string databaseName, string collectionName)
        {
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<T>(collectionName);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _collection.FindAsync(_ => true);
            return await entities.ToListAsync();
        }

        public async Task<T> GetById(string id)
        {
            var entity = await _collection.FindAsync(e => e.Id == id);
            return await entity.FirstOrDefaultAsync();
        }

        public async Task Insert(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task<bool> Update(T entity)
        {
            var updateResult = await _collection.ReplaceOneAsync(e => e.Id == entity.Id, entity);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> Delete(string id)
        {
            var deleteResult = await _collection.DeleteOneAsync(e => e.Id == id);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }

}
