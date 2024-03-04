using System;

namespace Task3._7_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Введите первое число:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Первое число: {num1}, Второе число: {num2}");

            SwapNumbers(ref num1, ref num2);

            Console.WriteLine($"Числа после обмена: Первое - {num1}, Второе - {num2}");
        }

        public static void SwapNumbers(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
