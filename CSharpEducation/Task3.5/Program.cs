namespace Task3._5;

class Program
{
    static void Main(string[] args)
    {
        //Создайте и реализуйте метод, который принимает на вход массив и инвертирует его.
        //Вызовите его в методе Main. Исходный массив задайте сами.
        //Инвертированный массив выведите на экран консоли.

        int[] nums = new int[] { 1, 2, 4, 5, 7 };

        Console.WriteLine("Исходный массив:");
        PrintArray(nums);

        InvertNums(nums);

        Console.WriteLine("\nИнвертированный массив:");
        PrintArray(nums);
    }

    public static void InvertNums(int[] arr)
    {
        //Array.Reverse(arr);

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

}

