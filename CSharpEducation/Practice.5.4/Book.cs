using System;
namespace Practice._5._4
{
	public class Book
	{
		public static int BooksCount = 0;

		public string BookName;
		public string BookAuthor;
		public int BookPublicYear;
		public string BookGenre;

		public Book(string name, string author, int year, string genre)
		{
            BookName = name;
            BookAuthor = author;
            BookPublicYear = year;
            BookGenre = genre;

            BooksCount++;
		}
	}
}

