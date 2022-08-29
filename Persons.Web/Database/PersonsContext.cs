using Microsoft.EntityFrameworkCore;
using Persons.Web.Models;

namespace Persons.Web.Database;

public class PersonsContext : DbContext
{
	public DbSet<Person>? Persons { get; init; }

	public PersonsContext() : base()
	{
	}

	public PersonsContext(DbContextOptions<PersonsContext> options) : base(options)
	{
	}
}