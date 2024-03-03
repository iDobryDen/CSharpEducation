namespace Practice._5._3;

//Создайте в папке проекта файл Person.cs, и создайте в нём новый public класс Person.Добавьте в него поля, отвечающие за возраст,
//имя, фамилию, название компании где работает человек.Добавьте в класс 3 конструктора:
//а)конструктор без аргументов, который задаёт значения по умолчанию для указанных полей;
//б)конструктор с аргументами, соответствующими полям класса;
//с)конструктор, принимающий только 2 аргумента: имя и возраст.Остальные параметры заполните значениями по умолчанию.


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
    }
}

