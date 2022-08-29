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
        var persons = await _personsContext.Persons!.ToArrayAsync();
        return View(persons);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] Person person, CancellationToken token = default)
    {
        if (!ModelState.IsValid)
        {
            return View(person);
        }

        await _personsContext.AddAsync(person, token);
        await _personsContext.SaveChangesAsync(token);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        var person = await _personsContext.Persons!.FirstOrDefaultAsync(p => p.Id == id);
        return View(person);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        var person = await _personsContext.Persons!.FirstOrDefaultAsync(p => p.Id == id);
        return View(person);
    }
}