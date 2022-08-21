using DAL;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace example1.Controllers
{
    public class PersonController : Controller
    {
        private IPersonManager _person;

        public PersonController(IPersonManager person)
        {
            _person = person;
        }
        [HttpPost]
        public IActionResult addPerson([FromBody]Person person)
        {
            _person.insertion(person);
            return Ok(person);
        }
        [HttpPost]
        public IActionResult updatePerson([FromBody]Person person)
        {
            _person.update(person);
            return Ok(person);
        }
        [HttpPost]
        public IActionResult deletePerson(int id)
        {
            _person.delete(id);
            return Ok(id);
        }
        [HttpPost]
        public IActionResult getPersons()
        {
            _person.GetPersonDetails();
            return Ok(new {Result = _person.GetPersonDetails()        });
        }
    }
}
