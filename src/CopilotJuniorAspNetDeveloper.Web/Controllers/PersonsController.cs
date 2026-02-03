using CopilotJuniorAspNetDeveloper.Application.Persons;
using Microsoft.AspNetCore.Mvc;

namespace CopilotJuniorAspNetDeveloper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly RetreiveAllPersonsHandler retrievePersonsHandler;

        public PersonsController(RetreiveAllPersonsHandler retrievePersonsHandler)
        {
            this.retrievePersonsHandler = retrievePersonsHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var persons = await retrievePersonsHandler.GetPeopleAsync();
            return Ok(persons);
        }
    }
}
