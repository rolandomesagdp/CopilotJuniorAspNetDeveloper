using Microsoft.EntityFrameworkCore;

namespace CopilotJuniorAspNetDeveloper.Infrastructure.Context
{
    public class DbInitializer
    {
        public static async Task InitializeDb(CopilotJuniorAspNetDeveloperDbContext dbContext)
        {
            await dbContext.Database.MigrateAsync();
            await DbContextSeeder.SeedAsync(dbContext);
        }
    }
}
