using System;
namespace bookStoreRecord
{
    class BookStore
    {
        public record Bookstore
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }
            public Bookstore()
            {
                ID = 0;
                Title = string.Empty;
                Author = string.Empty;
                Price = 0;
            }
            public Bookstore(int id, string title, string author, double price)
            {
                ID = id;
                Title = title;
                Author = author;
                Price = price;
            }
        }
        public static void Main()
        {
            Bookstore book1 = new(1, "Milo's Adventure", "Tyler Grayson Micheal", 6);
            Console.WriteLine(book1);

            Bookstore book2 = new(2, "The Blind Little Mole", "Gus Wilson", 8);
            Console.WriteLine(book2);

            Bookstore book3 = new(3, "Dilly's Little Trot", "Dylan Scott Hatt", 30);
            Console.WriteLine(book3);
        }
    }
}
