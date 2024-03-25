using System;

namespace BinarySearch;

/// <summary>
/// Двоичный поиск в отсортированном массиве.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Искать число <see cref="x"/> массиве целочисленных чисел.
    /// </summary>
    /// <param name="array">Массив целочисленных чисел.</param>
    /// <param name="x">Искомый элемент.</param>
    /// <returns>Индекс <see cref="x"/> в массиве. Иначе <c>-1</c>, если элемент не найден.</returns>
    public static int Search(int[] array, int x, int left, int right)
    {
        if (left > right) return -1;

        int middle = (left + right) / 2;
        if (x == array[middle]) return middle;
        else if (x > array[middle]) return Search(array, x, middle + 1, right);
        else if (x < array[middle]) return Search(array, x, left, middle - 1);

        return -1;
    }
}