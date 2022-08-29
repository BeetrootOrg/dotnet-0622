using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Persons.Web.Database;

namespace Persons.Web.Controllers;

public class PersonsController : Controller
{
    private readonly PersonsContext _personsContext;

    public PersonsController(PersonsContext personsContext)
    {
        _personsContext = personsContext;
    }

    public async Task<IActionResult> Index()
    {
        var persons = await _personsContext.Persons!.ToArrayAsync();
        return View(persons);
    }
}