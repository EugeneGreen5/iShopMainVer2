using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;

namespace iShopMain.Repositories.User
{
    public class InformationRepository : IRepository<Information>
    {
        private readonly ApplicationDbContext _context;

        public InformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Information item)
        {
            await _context.informations.AddAsync(item);
            await SaveAsync();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        
        }

        public Task<Information> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Information>> GetListAsync()
        {
            return await _context.informations.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Information item)
        {
            throw new NotImplementedException();
        }
    }
}
