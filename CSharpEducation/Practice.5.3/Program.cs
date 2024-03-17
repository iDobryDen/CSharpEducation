namespace Practice._5._3;

//Создайте в папке проекта файл Person.cs, и создайте в нём новый public класс Person.Добавьте в него поля, отвечающие за возраст,
//имя, фамилию, название компании где работает человек.Добавьте в класс 3 конструктора:
//а)конструктор без аргументов, который задаёт значения по умолчанию для указанных полей;
//б)конструктор с аргументами, соответствующими полям класса;
//с)конструктор, принимающий только 2 аргумента: имя и возраст.Остальные параметры заполните значениями по умолчанию.
//Создайте в класса Program три объекта тремя разными конструкторами.
//Для каждого из  объектов выведите на экран консоли значения их полей.

class Program
{
    static void Main(string[] args)
    {
        Person Den = new Person("Den", 15);


        //Den.Firstname = "Den";
        //Den.Lastname = "Pere";
        //Den.Age = 5;
        //Den.Company = "UdGU";

        Console.WriteLine($"Firstname: {Den.Firstname} | Lastname: {Den.Lastname} | Age: {Den.Age} | Company: {Den.Company}");

        // Создаем объекты с помощью разных конструкторов
        Person student1 = new Person("Denis", 35);
        Person student2 = new Person("Sonya", 35);
        Person student3 = new Person("Anna", 10);

        // Выводим на консоль значения полей каждого объекта
        Console.WriteLine($"Firstname: {student1.Firstname} | Age: {student1.Age} | Company: {student1.Company}");
        Console.WriteLine($"Firstname: {student2.Firstname} | Age: {student2.Age} | Company: {student2.Company}");
        Console.WriteLine($"Firstname: {student3.Firstname} | Age: {student3.Age} | Company: {student3.Company}");
    }
}

