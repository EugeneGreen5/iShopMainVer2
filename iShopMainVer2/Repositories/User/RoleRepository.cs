using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace iShopMainVer2.Repositories.User
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleAsync(String name){
            return await _context.Roles.FirstOrDefaultAsync(x => x.NameRole == name);
        }

        public void Dispose()
        {
            
        }

        public async Task<Role> Get(Guid id)
        {
            return await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
