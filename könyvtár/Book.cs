using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace könyvtár
{
	internal class Book
	{
		string title;
		string author;
		int pageCount;
		int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleaseYear { get => releaseYear; }


		public void GetBookByTitle(Book[] books, string title)
		{
			for (int i = 0; i < books.Length; i++)
			{
				if (books[i].Title == title)
				{
					Console.WriteLine(title + " könyv írója :" +  books[i].Author);
				}
			}
		}

		public void EditBookData()
		{
            Console.WriteLine("Milyen adat legyen: ");
			Console.WriteLine("1. Cím ");
			Console.WriteLine("2. Író");
			Console.WriteLine("3. Oldalszám");
			Console.WriteLine("4. Kiadás éve");

			int valasztas = int.Parse(Console.ReadLine());

			switch (valasztas)
			{
				case 1:
					Console.Write("Új cím: ");
					title = Convert.ToString(Console.ReadLine());
					break;
				case 2:
					Console.Write("Új író: ");
					author = Console.ReadLine();
					break;
				case 3:
					Console.Write("Új oldalszám: ");
					pageCount = int.Parse(Console.ReadLine());
					break;
				case 4:
					Console.Write("Új kiadási év: ");
					releaseYear = int.Parse(Console.ReadLine());
					break;
				default:
					Console.WriteLine("Érvénytelen választás!");
					break;
			}

			Console.WriteLine("A könyv adatai frissítve lettek.");

		}

		public override string ToString()
		{

			return $"könyv neve: {title}, írója: {author}, oldalak száma: {pageCount}, kiadása: {releaseYear}";
		}
	}
}

