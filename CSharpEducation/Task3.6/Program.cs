namespace Task3._6;

class Program
{
    static void Main(string[] args)
    {
        //Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и менять его знак на противоположный.
        //Метод должен принимать один аргумент и не возвращать ничего.

        int arr = int.Parse(Console.ReadLine());

        Minus(ref arr);
        Console.WriteLine(arr);
    }
    public static void Minus(ref int arr)
    {
        arr = -arr;
    }
}

