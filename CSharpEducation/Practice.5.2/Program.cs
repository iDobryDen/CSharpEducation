namespace Practice._5._2;

class Program
{
    static void Main(string[] args)
    {
        Person Egor = new Person();
        Person Age = new Person();

        Egor.Age = 5;

        Egor.CheckIsAdult();



        Console.WriteLine(Egor.CheckIsAdult());
    }
}

