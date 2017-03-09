﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int ISBN { get; set; }
    public decimal Price { get; set; }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class BookLibraryModification
{
    static void Main()
    {
        int numberOfBooks = int.Parse(Console.ReadLine());
        Library myLibrary = new Library() { Name = "myLibrary", Books = new List<Book>() };

        Dictionary<string, DateTime> titleYearSort = new Dictionary<string, DateTime>();

        for (int i = 0; i < numberOfBooks; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            myLibrary.Books.Add(new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = int.Parse(input[4]),
                Price = decimal.Parse(input[5])
            });
        }

        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        for (int i = 0; i < myLibrary.Books.Count; i++)
        {
            if (myLibrary.Books[i].ReleaseDate > startDate)
            {
                titleYearSort[myLibrary.Books[i].Title] = myLibrary.Books[i].ReleaseDate;
            }
        }

        foreach (var item in titleYearSort.OrderBy(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
        }
    }

}

