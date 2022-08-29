using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persons.Web.Database;
using Persons.Web.Models;

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
		Person[]? persons = await _personsContext.Persons?.ToArrayAsync();
		return View(persons ?? Array.Empty<Person>());
	}
}