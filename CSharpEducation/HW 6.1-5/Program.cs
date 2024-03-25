//1. Создать статичный класс Search
//2. Реализовать статичный метод LinearSearch для поиска в массиве int некоторого числа с помощью линейного поиска.
//3. Реализовать статичный метод BinarySearch для поиска в массиве int некоторого числа с помощью бинарного поиска.
//4. Реализовать статичный метод BinarySearch для поиска в массиве string некоторой строки с помощью бинарного поиска.
//5. Проверьте как работают эти методы в классе Program.

namespace HW_6._1_5;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}

static class Search
{
    public static void Main()
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int SeekNumber = 6;
        LinearSearch(array, SeekNumber);
        BinarySearch(array, SeekNumber);
    }

    public static void LinearSearch(int[] _array, int _SeekNumber)
    {
        int LinearIteration = 0;
        int SuccessSearch = 0;
        for (int i = 0; i <= _array.Length; i++)
        {
            LinearIteration++;
            if (_SeekNumber == i)
            {
                Console.WriteLine($"Число {_SeekNumber} найдено за {LinearIteration} линейных циклов");
                SuccessSearch++;
            }
        }
        if (SuccessSearch == 0)
        {
            Console.WriteLine($"Число " + _SeekNumber + " не найдено за " + LinearIteration + " линейных циклов");
        }
    }

    public static int BinarySearch(int[] _array, int _SeekNumber)
    {
        int left_index = 0;
        int right_index = _array.Length - 1;
        //int middle_index = (left_index + right_index) / 2;

        int BinaryIteration = 0;
        int SuccessSearch = 0;

        if (left_index > right_index)
        {
            Console.WriteLine($"Массив {_array} не отсортирован по возрастанию");
        }

        while (true)
        {
            int middle_index = (left_index + right_index) / 2;
            BinaryIteration++;
            if (_SeekNumber == _array[middle_index])
            {
                Console.WriteLine($"Число {_SeekNumber} найдено за {BinaryIteration} бинарных циклов");
                SuccessSearch++;
                return middle_index;
            }
            else if (_SeekNumber < _array[middle_index])
            {
                right_index = middle_index - 1;
            }
            else if (_SeekNumber > _array[middle_index])
            {
                left_index = middle_index  + 1;
            }
            //if (SuccessSearch == 0)
            //{
            //    Console.WriteLine($"Число " + _SeekNumber + " не найдено за " + BinaryIteration + " линейных циклов");
            //}
        }
        return -1;
    }
}

// почему то находит не за 2 бинарных цикла, а за 3, хотя уже на второй итерации middle_index равен _SeekNumber