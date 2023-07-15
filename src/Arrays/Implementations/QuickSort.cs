using Arrays.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Implementations
{
    public class QuickSort<T> : IArraySorter<T> where T : IComparable
    {
        public T[] AscendingSort(T[] array)
        {
          return  Sort(array, 0, array.Length - 1);
        }

        public T[] DescendingSort(T[] array)
        {
            throw new NotImplementedException();
        }
        private static T[] Sort<T>(T[] array, int lower, int upper)
 where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }
        private static int Partition<T>(T[] array, int lower, int upper)
 where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            // or: T pivot = array[(lower + upper) / 2];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
               Utilities.Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }

    }
}
