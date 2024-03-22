namespace BubbleSort;

/// <summary>
/// Сортировка пузырьком.
/// </summary>
public static class BubbleSort
{
    /// <summary>
    /// Сортирвать элементы массива.
    /// </summary>
    /// <param name="array">Массив для сортировки.</param>

    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var temp = array[i + 1];
                    array[j + 1] = array[j];
                    array[i] = temp;
                }
            }
        }
    }
}