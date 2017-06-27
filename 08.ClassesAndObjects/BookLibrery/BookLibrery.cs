namespace BookLibrery
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrery
    {
        public class Book
        {
            public Book(string title, string author, string publisher, DateTime releaseDate, string number, decimal price)
            {
                this.Title = title;
                this.Author = author;
                this.Publisher = publisher;
                this.ReleaseDate = releaseDate;
                this.IsbnNumber = number;
                this.Price = price;
            }

            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string IsbnNumber { get; set; }
            public decimal Price { get; set; }
        }

        public class Library
        {
            public Library(string name)
            {
                this.Name = name;
                this.Books = new List<Book>();
            }

            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Library library = new Library("California");

            for (int i = 0; i < n; i++)
            {
                var dataLine = Console.ReadLine().Split();

                var book = new Book(dataLine[0], dataLine[1], dataLine[2],
                    DateTime.ParseExact(dataLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), dataLine[4],
                    decimal.Parse(dataLine[5]));

                library.Books.Add(book);
            }

            Dictionary<string, decimal> booksAmountByAuthors = new Dictionary<string, decimal>();

            for (int i = 0; i < library.Books.Count; i++)
            {
                var currentBookAuthor = library.Books[i].Author;
                var currentBookPrice = library.Books[i].Price;

                if (!booksAmountByAuthors.ContainsKey(currentBookAuthor))
                {
                    booksAmountByAuthors[currentBookAuthor] = 0;
                }

                booksAmountByAuthors[currentBookAuthor] += currentBookPrice;
            }
            
            foreach (var book in booksAmountByAuthors.OrderByDescending(v => v.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", book.Key, book.Value);
            }
        }
    }
}
