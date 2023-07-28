namespace Arrays.Implementations;

public class Sorting
{

    public static void BubbleSort(int[] array)
    {
        for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
        {
            for (int i = 0; i < partIndex; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                }
            }
        }
    }
    public static void SelectionSort(int[] array)
    {
        for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
        {
            int largestAt = 0;
            for (int i = 1; i <= partIndex; i++)
            {
                if (array[i] > array[largestAt])
                {
                    largestAt = i;
                }
            }
            Swap(array, largestAt, partIndex);
        }
    }
    public static void InsertionSort(int[] array)
    {
        for (int partIndex = 1; partIndex < array.Length; partIndex++)
        {
            int curUnsorted = array[partIndex];
            int i;
            for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
            {
                array[i] = array[i - 1];
            }

            array[i] = curUnsorted;
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        if (i == j)
            return;
        (array[i], array[j]) = (array[j], array[i]);
    }
}