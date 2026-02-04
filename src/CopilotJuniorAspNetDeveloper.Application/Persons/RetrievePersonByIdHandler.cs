namespace CopilotJuniorAspNetDeveloper.Application.Persons
{
    public class RetrievePersonByIdHandler
    {
        private readonly IPersonsRepository personsRepository;

        public RetrievePersonByIdHandler(IPersonsRepository personsRepository)
        {
            this.personsRepository = personsRepository;
        }
        
        public async Task<PersonDto> GetPersonByIdAsync(int id)
        {
            var person = await personsRepository.GetByIdAsync(id);
            
            return new PersonDto
            {
                Id = person.Id,
                Name = person.Name,
                LastName = person.LastName
            };
        }
    }
}
