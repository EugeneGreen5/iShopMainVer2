
namespace iShopMain.Repositories.User
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<List<T>> GetListAsync();
        Task<T> Get(Guid id);
        Task CreateAsync(T item);
        void Delete(Guid id);
        void Update(T item);
        Task SaveAsync();
    }
}
