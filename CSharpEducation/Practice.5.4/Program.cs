//* Создайте в папке проекта файл Book.cs, и создайте в нём новый public класс Book. В класс добавьте static поле BooksCount,
//которое будет использоваться для подсчёта созданных книг. Создайте конструктор класса, в котором увеличивайте значение BooksCount на единицу.
//В класс добавьте поля, соответствующие названию книги, автору книги, год издания, жанр. Создайте несколько книг в классе Program.
//Выведите на экран консоли значение BooksCount.
namespace Practice._5._4;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("skazkaocaresoltane1", "Pushkin", 1782, "Skazki");
        Book book2 = new Book("skazkaocaresoltane2", "Pushkin", 1782, "Skazki");
        Book book3 = new Book("skazkaocaresoltane3", "Pushkin", 1782, "Skazki");

        Console.WriteLine("Total number of books created: " + Book.BooksCount);
    }
}