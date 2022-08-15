using System;
using System.Linq;
using EfExample.Contexts;
using Microsoft.EntityFrameworkCore;

await using var context = new ShopContext();

var customers = await context.Customers.ToArrayAsync();
foreach (var customer in customers)
{
	Console.WriteLine($"{customer.Id}: {customer.FirstName} {customer.LastName}");
}

var employees = await context.Employees
	.Include(x => x.Position)
	.ToArrayAsync();

foreach (var employee in employees)
{
	Console.WriteLine($@"{employee.Id}: {employee.FirstName} {employee.LastName}. 
	Salary: {employee.Salary}. 
	Position Name: {employee.Position.Name}");
}

var positions = await context.Positions
	.Include(x => x.Employees)
	.ToArrayAsync();

foreach (var position in positions)
{
	Console.WriteLine($@"Position: {position.Name}. Employees count: {position.Employees.Count()}");
}