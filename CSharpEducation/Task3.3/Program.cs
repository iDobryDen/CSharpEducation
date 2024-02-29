namespace Task3._3;

class Program
{
    static void Main(string[] args)
    {

        //Создайте и реализуйте метод, который вычисляет сумму двух чисел и возвращает их сумму.
        //Вызовите метод в методе Main и выведите результат на экран. Два числе передайте в метод как вам угодно.
        //Метод, который вы напишите, не должен работать с консолью.
        int c = 25;
        int d = 10;
        int z = GetArrow(c, d);
        Console.WriteLine(z);
    }
    public static int GetArrow(int A, int B)
    {
        return A + B;
    }
}

