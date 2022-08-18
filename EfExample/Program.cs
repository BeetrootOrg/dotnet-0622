﻿using System;
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
    Console.WriteLine($"title {book.Book_Title} genre {book.Book_Genre} author {book.Author.FirstName} {book.Author.LastName}");
}

var authors = await context.Authors
    .Include(x => x.Books)
    .ToArrayAsync();

foreach (var author in authors)
{
    Console.WriteLine();
    Console.WriteLine($"FirstName {author.FirstName} LastName {author.LastName} Count {author.Books.Count()}");
}