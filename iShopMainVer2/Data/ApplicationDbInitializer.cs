using Microsoft.EntityFrameworkCore;

namespace iShopMain.Data
{
    public static class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext context) {
            context.Database.Migrate();          
        }
    }
}
