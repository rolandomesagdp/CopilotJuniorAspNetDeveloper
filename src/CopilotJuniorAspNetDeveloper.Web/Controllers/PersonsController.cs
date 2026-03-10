using CopilotJuniorAspNetDeveloper.Application.Persons;
using Microsoft.AspNetCore.Mvc;

namespace CopilotJuniorAspNetDeveloper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly RetrieveAllPersonsHandler retrievePersonsHandler;
        private readonly RetrievePersonByIdHandler retrievePersonByIdHandler;

        public PersonsController(RetrieveAllPersonsHandler retrievePersonsHandler,
            RetrievePersonByIdHandler retrievePersonByIdHandler)
        {
            this.retrievePersonsHandler = retrievePersonsHandler;
            this.retrievePersonByIdHandler = retrievePersonByIdHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IActionResult result;
            try
            {
                var persons = await retrievePersonsHandler.GetPersonsAsync();
                result = Ok(persons);
            }
            catch (Exception ex)
            {
                result = StatusCode(500, $"Internal server error: {ex.Message}");
            }
            return result;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            IActionResult result;
            try
            {
                var person = await retrievePersonByIdHandler.GetPersonByIdAsync(id);
                if (person == null)
                {
                    result = NotFound();
                }
                else
                {
                    result = Ok(person);
                }
            }
            catch (Exception ex)
            {
                result = StatusCode(500, $"Internal server error: {ex.Message}");
            }
            return result;
        }
    }
}
