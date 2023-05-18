using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iShopMain.Repositories.User
{
    public class AccountRepository : IRepository<Account>
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<Account> Get(Guid id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task CreateAsync(Account item)
        {
            await _context.Accounts.AddAsync(item);
            await SaveAsync();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<Account>> GetListAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Account item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        public Task<bool> AnyAsync(Expression<Func<Account, bool>> expression, CancellationToken cancellationToken = default)
        {
            _context.Set<Account>().AnyAsync(expression, cancellationToken);
        }
    }
}
