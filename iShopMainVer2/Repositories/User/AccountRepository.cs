using iShopMainVer2.Data;
using iShopMainVer2.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iShopMainVer2.Repositories.User
{
    public class AccountRepository : IRepository<AccountEntity>
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<AccountEntity> Get(Guid id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task CreateAsync(AccountEntity item)
        {
            await _context.Accounts.AddAsync(item);
            await SaveAsync();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<AccountEntity>> GetListAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(AccountEntity item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        public Task<bool> AnyAsync(Expression<Func<AccountEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //_context.Set<AccountEntity>().AnyAsync(expression, cancellationToken);
        }
    }
}
