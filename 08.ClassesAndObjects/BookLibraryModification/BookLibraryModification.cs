namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class BookLibraryModification
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

            Dictionary<string, DateTime> booksTitleAndRealiseDate = new Dictionary<string, DateTime>();

            for (int i = 0; i < library.Books.Count; i++)
            {
                var currentBookTitle = library.Books[i].Title;
                var currentBookRealise = library.Books[i].ReleaseDate;

                if (!booksTitleAndRealiseDate.ContainsKey(currentBookTitle))
                {
                    booksTitleAndRealiseDate[currentBookTitle] = new DateTime();
                }

                booksTitleAndRealiseDate[currentBookTitle] = currentBookRealise;
            }

            var startDateRealise = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in booksTitleAndRealiseDate.Where(d => d.Value > startDateRealise).OrderBy(d => d.Value).ThenBy(t => t.Key))
            {
                string format = "dd.MM.yyyy";
                Console.WriteLine("{0} -> {1}", book.Key, book.Value.ToString(format));
            }
        }
    }
}
