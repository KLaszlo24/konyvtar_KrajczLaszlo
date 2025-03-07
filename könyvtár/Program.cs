namespace könyvtár
{
	internal class Program
	{
		static void Main(string[] args)
		{
			


			Book book1 = new Book("Kacsa", "Abádi Ervin", 200, 1870);
			Book book2 = new Book("Liba", "Nagy Lajos", 210, 1970);
			Book book3 = new Book("Az Ember", "Kis Géza", 120, 2000);


			Book[] books = [book1, book2, book3];

            Console.WriteLine($"{book1.ToString()}");
			Console.WriteLine($"{book2.ToString()}");
			Console.WriteLine($"{book3.ToString()}");

			book1.GetBookByTitle(books, "Kacsa");
			book1.EditBookData();
            Console.WriteLine(book1);
        }
	}
}
