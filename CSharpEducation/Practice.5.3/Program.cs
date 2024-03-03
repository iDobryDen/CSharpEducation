namespace Practice._5._3;

class Program
{
    static void Main(string[] args)
    {
        Person Den = new Person("Den", "Pere", 5, "UdGU");


        //Den.Firstname = "Den";
        //Den.Lastname = "Pere";
        //Den.Age = 5;
        //Den.Company = "UdGU";

        Console.WriteLine($"Firstname: {Den.Firstname} | Lastname: {Den.Lastname} | Age: {Den.Age} | Company: {Den.Company}");
    }
}

