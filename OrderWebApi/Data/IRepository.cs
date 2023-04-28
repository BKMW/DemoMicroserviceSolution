using OrderWebApi.Entities;

namespace OrderWebApi.Data
{
    public interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
        Task Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(string id);
    }
}
