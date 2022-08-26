﻿using System;
using System.Linq;
using EfExample.Contexts;
using Microsoft.EntityFrameworkCore;

await using var context = new LibraryContext();
var customers = await context.Customers.ToArrayAsync();
foreach (var customer in customers)
{
	Console.WriteLine($"{customer.Id}: {customer.Name} {customer.LastName}");
}
