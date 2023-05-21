using iShopMainVer2.Models.Entity.UserInfo;
using iShopMainVer2.Models.Entity;
using System.Linq.Expressions;

namespace iShopMainVer2.Repositories.Order;

public interface IOrderRepository <T> : IDisposable
    where T : BaseEntity
{ 
    Task CreateAsync (T entity);
    Task DeleteAsync (T entity);
    Task<T> GetAsync (T entity);
    Task<T> UpdateAsync (T entity);
}
