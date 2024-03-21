//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace HW_6._1_5;

//static class Search
//{
//    public static void Main2()
//    {
//       int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//       int SeekNumber = 6;
//       LinearSearch(array, SeekNumber);
//    }

//    public static void LinearSearch(int[] array, int SeekNumber)
//    {
//        int LinearIteration = 0;
//        for (int i = 0; i <= array.Length; i++)
//        {
//            LinearIteration++;
//            if (SeekNumber == i)
//            {
//                Console.WriteLine($"Число " + SeekNumber + " найдено за " + LinearIteration + " линейных циклов");
//            }
//            else
//            {
//                Console.WriteLine($"Число " + SeekNumber + " не найдено за " + LinearIteration + " линейных циклов");
//            }
//        }
//    }
//}

