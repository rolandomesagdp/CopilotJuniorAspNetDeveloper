using CopilotJuniorAspNetDeveloper.Domain.Persons;

namespace CopilotJuniorAspNetDeveloper.Infrastructure.Context
{
    public static class DbContextSeeder
    {
        public static async Task SeedAsync(CopilotJuniorAspNetDeveloperDbContext context)
        {
            if (!context.Persons.Any())
            {
                context.Persons.AddRange(
                    new Person { Name = "Rolando", LastName = "Mesa" },
                    new Person { Name = "Darío", LastName = "Mesa" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
