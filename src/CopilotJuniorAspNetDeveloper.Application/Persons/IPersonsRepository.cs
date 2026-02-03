using CopilotJuniorAspNetDeveloper.Domain.Persons;

namespace CopilotJuniorAspNetDeveloper.Application.Persons
{
    public interface IPersonsRepository
    {
        /// <summary>
        /// Gets all persons.
        /// </summary>
        /// <returns>Returns all available persons in the system.</returns>
        public Task<IEnumerable<Person>> GetAll();
    }
}
