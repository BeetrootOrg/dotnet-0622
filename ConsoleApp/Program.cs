using System;
using ConsoleApp.Contexts;
using Microsoft.EntityFrameworkCore;

await using var context = new LibraryContext();

var authors = await context.Authors.ToArrayAsync();

foreach (var author in authors)
{
    Console.WriteLine($"{author.FirstName}");
}