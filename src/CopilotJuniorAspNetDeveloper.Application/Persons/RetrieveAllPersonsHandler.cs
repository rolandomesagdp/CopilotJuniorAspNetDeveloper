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
            var personDtos = new List<PersonDto>();
            foreach (var person in allPersons)
            {
                var personDto = new PersonDto
                {
                    Id = person.Id,
                    Name = person.Name,
                    LastName = person.LastName
                };
                personDtos.Add(personDto);
            }
            return personDtos;
        }
    }
}
