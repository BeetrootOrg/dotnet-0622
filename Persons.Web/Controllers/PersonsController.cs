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

    public async Task<IActionResult> Index(CancellationToken token = default)
    {
        var persons = await _personsContext.Persons!.ToArrayAsync(token);
        return View(persons);
    }

    public async Task<IActionResult> Details(int? id, CancellationToken token = default)
    {
        var person = await _personsContext.Persons!.FirstOrDefaultAsync(p => p.Id == id, token);
        return View(person);
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

    public async Task<IActionResult> Delete(int? id, CancellationToken token = default)
    {
        var person = await _personsContext.Persons!.FirstOrDefaultAsync(p => p.Id == id, token);
        return View(person);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeletePerson(int id, CancellationToken token = default)
    {
        _personsContext.Remove(new Person { Id = id });
        await _personsContext.SaveChangesAsync(token);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id, CancellationToken token = default)
    {
        var person = await _personsContext.Persons!.FirstOrDefaultAsync(p => p.Id == id, token);
        return View(person);
    }

    [HttpPost]
    public async Task<IActionResult> Edit([FromForm] Person person, CancellationToken token = default)
    {
        if (!ModelState.IsValid)
        {
            return View(person);
        }

        _personsContext.Update(person);
        await _personsContext.SaveChangesAsync(token);

        return RedirectToAction(nameof(Index));
    }
}