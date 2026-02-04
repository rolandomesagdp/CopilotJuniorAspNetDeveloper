namespace CopilotJuniorAspNetDeveloper.Application.Persons
{
    public class RetrieveAllPersonsHandler
    {
        private readonly IPersonsRepository personsRepository;

        public RetrieveAllPersonsHandler(IPersonsRepository personsRepository)
        {
            this.personsRepository = personsRepository;
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync()
        {
            var allPersons = await personsRepository.GetAll();
            return allPersons.Select(person => new PersonDto
            {
                Id = person.Id,
                Name = person.Name,
                LastName = person.LastName
            });
        }
    }
}
