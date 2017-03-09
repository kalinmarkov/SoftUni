using System;
using System.Collections.Generic;
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

class BookLibrary
{
    static void Main()
    {
        int numberOfBooks = int.Parse(Console.ReadLine());
        Library myLibrary = new Library() { Name = "myLibrary", Books = new List<Book>() };
        Dictionary<string, decimal> authorPriceSort = new Dictionary<string, decimal>();

        for (int i = 0; i < numberOfBooks; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            myLibrary.Books.Add(new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.Parse(input[3]),
                ISBN = int.Parse(input[4]),
                Price = decimal.Parse(input[5])
            });
        }

        for (int i = 0; i < myLibrary.Books.Count; i++)
        {
            if (authorPriceSort.ContainsKey(myLibrary.Books[i].Author))
            {
                authorPriceSort[myLibrary.Books[i].Author] += myLibrary.Books[i].Price;
                continue;
            }
            authorPriceSort[myLibrary.Books[i].Author] = myLibrary.Books[i].Price;
        }

        foreach (var item in authorPriceSort.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value:f2}");
        }
    }

}

