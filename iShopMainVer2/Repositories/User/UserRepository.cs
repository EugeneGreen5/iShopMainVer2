using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace iShopMain.Repositories
{
    public class UserRepository : IRepository<AppUser>
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task CreateAsync(AppUser item)
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

        public Task<AppUser> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppUser>> GetListAsync()
        {
            return await _context.Users.ToListAsync();

        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(AppUser item)
        {
            throw new NotImplementedException();
        }
    }

}
