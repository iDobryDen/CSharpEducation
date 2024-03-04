namespace Task3._8_HW;

class Program
{
    static void Main(string[] args)
    {
        //*Создайте и реализуйте метод, который будет принимать массив на вход убирать из него отрицательные числа
        //и возвращать новый изменённый массив. Через out параметр возвращать количество удалённых символов.

        int[] nums = new int[] { 1, 2, -4, 5, -6 };
        Console.WriteLine("Исходный массив:");
        PrintArray(nums);

        int[] nums2 = negative_nums(nums, out int iskl);

        Console.WriteLine("\nМассив без отрицательных значений:");
        PrintArray(nums2);

        Console.WriteLine($"\nКоличество удаленных отрицательных чисел: {iskl}");

    }
    public static int[] negative_nums(int[] args, out int iskl)
    {
        iskl = 0;
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] < 0)
            {
                iskl++;
                args[i] = 0; // Заменяем отрицательное число на 0
            }
        }
        int[] nums2 = new int[args.Length - iskl];
        int z = 0;
        foreach (int num in args)
        {
            if (num != 0)
            {
                nums2[z] = num;
                z++;
            }
        }
        return nums2;
    }

    static void PrintArray(int[] args)
    {
        foreach (var item in args)
        {
            Console.Write(item + " ");
        }
    }
}

