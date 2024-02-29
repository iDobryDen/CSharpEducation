namespace Task3._4;

class Program
{
    static void Main(string[] args)
    {
        //Создайте и реализуйте метод, который принимает на вход размер массива n и возвращает пустой массив указанного размера.
        //Вызовите метод в методе Main и заполните его полученный массив. Содержимое массива выведите на экран.

        Console.WriteLine("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = GetArray(n);

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("Введите элемент массива: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вы ввели: ");
        foreach (int j in myArray)
        {
            Console.WriteLine(j);
        }
    }
    public static int[] GetArray(int n)
    {
        return new int[n];
    }
}

