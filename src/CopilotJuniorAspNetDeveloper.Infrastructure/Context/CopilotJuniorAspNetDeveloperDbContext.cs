using CopilotJuniorAspNetDeveloper.Domain.Persons;
using Microsoft.EntityFrameworkCore;

namespace CopilotJuniorAspNetDeveloper.Infrastructure.Context
{
    public class CopilotJuniorAspNetDeveloperDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public CopilotJuniorAspNetDeveloperDbContext(DbContextOptions<CopilotJuniorAspNetDeveloperDbContext> options) : base(options) { }
    }
}
