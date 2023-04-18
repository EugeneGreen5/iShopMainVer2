using iShopMain.Models.Entity.UserInfo;

namespace iShopMainVer2.Repositories.User
{
    public interface IRoleRepository : IDisposable
    {
        public Task<Role> GetRoleAsync(String name);
        public Task SaveAsync();
        public void Dispose();
        public Task<Role> Get(Guid id);
    }
}
