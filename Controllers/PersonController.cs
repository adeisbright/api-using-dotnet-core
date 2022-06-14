using Microsoft.AspNetCore.Mvc;
using Weather.Models;
using Weather.Services;


namespace Weather.Controllers;


[ApiController]
[Route("[controller]")]

public class PersonController : ControllerBase
{
    public PersonController()
    {

    }

    [HttpGet]
    public ActionResult<List<Person>> GetAll() => PersonService.getPersons();

    [HttpGet("{id}")]
    public ActionResult<Person> Get(int id)
    {
        var p = PersonService.getPerson(id);
        if (p == null)
        {
            return NotFound();
        }
        return p;
    }

    // [HttpPost]
    // public ActionResult Create(Person p)
    // {
    //     PersonService.addPerson(p);
    //     return CreatedAtAction(nameof(Create), p);
    // }

    // [HttpPut("{id}")]
    // public ActionResult Update(int id, Person person)
    // {

    // }

    // [HttpDelete("{id}")]
    // public ActionResult Delete(int id, Person person)
    // {

    // }
}