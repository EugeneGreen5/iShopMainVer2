using iShopMainVer2.Data;
using iShopMainVer2.Models.Entity.UserInfo;
using iShopMainVer2.Models.Entity.Order;
using System.Linq.Expressions;

namespace iShopMainVer2.Repositories.Order;

public class AddressRepository : IOrderRepository<AddressEntity>
{
    private readonly ApplicationDbContext _context;
    public AddressRepository (ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(AddressEntity entity)
    {
        await _context.Address.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(AddressEntity entity)
    {

    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<AddressEntity> GetAsync(AddressEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<AddressEntity> UpdateAsync(AddressEntity entity)
    {
        throw new NotImplementedException();
    }
}
