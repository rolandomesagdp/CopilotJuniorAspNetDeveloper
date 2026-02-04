using CopilotJuniorAspNetDeveloper.Application.Persons;
using CopilotJuniorAspNetDeveloper.Infrastructure.Context;
using CopilotJuniorAspNetDeveloper.Domain.Persons;
using Microsoft.EntityFrameworkCore;

namespace CopilotJuniorAspNetDeveloper.Infrastructure.Persons
{
    public class PersonsRepository : IPersonsRepository
    {
        private readonly CopilotJuniorAspNetDeveloperDbContext dbContext;

        public PersonsRepository(CopilotJuniorAspNetDeveloperDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var persons = await dbContext.Persons.ToListAsync();
            return persons;
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            var persons = await dbContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
            return persons;
        }
    }
}
