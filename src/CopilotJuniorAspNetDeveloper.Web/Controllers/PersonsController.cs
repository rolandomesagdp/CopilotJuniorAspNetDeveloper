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
            try
            {
                var persons = await retrievePersonsHandler.GetPersonsAsync();
                return Ok(persons);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var person = await retrievePersonByIdHandler.GetPersonByIdAsync(id);
                if (person == null)
                {
                    return NotFound();
                }
                return Ok(person);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
