using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Contracts
{
    public interface IArraySorter<T> where T : IComparable
    {
        T[] AscendingSort(T[] array);
        T[] DescendingSort(T[] array);

    }
}
