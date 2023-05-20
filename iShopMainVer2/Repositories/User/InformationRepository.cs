using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace iShopMain.Repositories.User
{
    public class InformationRepository : IRepository<InformationEntity>
    {
        private readonly ApplicationDbContext _context;

        public InformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> AnyAsync(Expression<Func<AccountEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(InformationEntity item)
        {
            await _context.Informations.AddAsync(item);
            await SaveAsync();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        
        }

        public Task<InformationEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InformationEntity>> GetListAsync()
        {
            return await _context.Informations.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(InformationEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
