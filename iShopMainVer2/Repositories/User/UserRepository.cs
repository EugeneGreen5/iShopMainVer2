using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iShopMain.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public Task<bool> AnyAsync(Expression<Func<AccountEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(UserEntity item)
        {
            try
            {
                await _context.Users.AddAsync(item);
            } catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
            await SaveAsync();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        public Task<UserEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserEntity>> GetListAsync()
        {
            return await _context.Users.ToListAsync();

        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(UserEntity item)
        {
            throw new NotImplementedException();
        }
    }

}
