using Arrays.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Implementations
{
    public class SelectionSort<T> : IArraySorter<T> where T : IComparable
    {
        public T[] AscendingSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Utilities.Swap(array, i, minIndex);
            }

            return array;
        }

        public T[] DescendingSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;
                T maxValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(maxValue) > 0)
                    {
                        maxIndex = j;
                        maxValue = array[j];
                    }
                }
                Utilities.Swap(array, i, maxIndex);
            }

            return array;
        }
    }
}
