using Arrays.Contracts;
using Arrays.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IArraySorter<int> arraySorter=new QuickSort<int>();
            var arr = new[] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            arraySorter.AscendingSort(arr);
        }
    }
}
