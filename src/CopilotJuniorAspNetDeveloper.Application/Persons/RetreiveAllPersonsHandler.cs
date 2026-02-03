using CopilotJuniorAspNetDeveloper.Domain.Persons;

namespace CopilotJuniorAspNetDeveloper.Application.Persons
{
    public class RetreiveAllPersonsHandler
    {
        private readonly IPersonsRepository personsRepository;

        public RetreiveAllPersonsHandler(IPersonsRepository personsRepository)
        {
            this.personsRepository = personsRepository;
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            return await personsRepository.GetAll();
        }
    }
}
