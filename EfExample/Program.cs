using System;
using System.Linq;
using EfExample.Contexts;
using Microsoft.EntityFrameworkCore;

await using var context = new LibraryContext();

var customers = await context.Customers.ToArrayAsync();

foreach (var customer in customers)
{
    Console.WriteLine(customer.FirstName);
    Console.WriteLine(customer.LastName);
}

var books = await context.Books
    .Include(x => x.Author)
    .ToArrayAsync(); 

foreach (var book in books)
{
    Console.WriteLine($"title {book.Book_Title} genre {book.Book_Genre} author {book.Author}");
}

	

//foreach (var employee in employees)
//{
//	Console.WriteLine($@"{employee.Id}: {employee.FirstName} {employee.LastName}. 
//	Salary: {employee.Salary}. 
//	Position Name: {employee.Position.Name}");
//}

//var positions = await context.Positions
//	.Include(x => x.Employees)
//	.ToArrayAsync();

//foreach (var position in positions)
//{
//	Console.WriteLine($@"Position: {position.Name}. Employees count: {position.Employees.Count()}");
//}