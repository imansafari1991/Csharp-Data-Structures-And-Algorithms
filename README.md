# Data-Structures-And-Algorithms

# Data types

While developing applications in the C# language, you could use various data types divided into two groups, namely **value types** and **reference types**. 
The difference between them is straightforward—a variable of a value type directly contains data, while a variable of a reference type stores a reference to data, as shown as follows:
As you can see, a Value type stores its actual Value directly in the Stack memory, while a Reference type only stores a Reference here. The actual Value is located in the Heap memory. Therefore, it is also possible to have two or more variables of a reference type that reference the same Value.

# Arrays
When you want to store a set of variables, you can use **Arrays**. When you face arrays, you sometimes need to **Sort** them. There are some familiar sorting algorithms, such as :
**Selection sort**, **Insertion sort**, **Bubble sort**, and **Quick sort**.

## Selection sort
Selection sort is the most straightforward sorting algorithm. The algorithm divides the array into two parts, namely **sorted** and **unsorted**. In the following iterations, the algorithm finds the **smallest** element in the unsorted part and exchanges it with the first element in the unsorted part. Before writing code, let's sort an array with nine elements [-11, 12, -42, 0, 1, 90, 68, 6, -9].

![image](https://github.com/imansafari1991/Csharp-Data-Structures-And-Algorithms/assets/52294855/a4058027-62cf-4df4-8278-964fa8b5b735)


At the first step of algorithm **(i=0)**, we consider the sorted part of the array empty. We consider the i*th* index of the array as the minimum Value. Try to sweep at the rest elements of the array with the *m* index that starts from **i+1** and find the minimum value of the array by comparing each element with minValue. In each iteration, compare the element's value with minValue, and substitute it with minValue.
In the preceding code, you can find the implementation of ascending sort for a generic array.
[Implementation Of Ascending and Descending SelectionSort](https://github.com/imansafari1991/Csharp-Data-Structures-And-Algorithms/blob/master/src/Arrays/Implementations/SelectionSort.cs "Implementation Of Ascending and Descending SelectionSort")
```
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
```
I added some tests here,  
[Test Selection Sort  Algorithm](https://github.com/imansafari1991/Csharp-Data-Structures-And-Algorithms/blob/master/test/Array.Tests/SelectionSortTests.cs "Test Selection Sort  Algorithm") instead of calling method and get input

# Simple lists
Arrays are really useful data structures, and they are applied in many algorithms. However, in some cases their application could be complicated due to their nature, which does not
allow to increase or decrease the length of the already-created array. What should you do if you do not know the total number of elements to store in the collection? Do you need to create a very big array and just not use unnecessary elements? Such a solution does not sound good, does it? A much better approach is to use a data structure that makes it possible to dynamically increase the size of the collection if it is necessary.
## Array list
The first data structure that meets this requirement is the array list, which is represented by the ArrayList class from the System.Collections namespace. You can use this class to store big collections of data, to which you can easily add new elements when necessary. Of course, you can also remove them, count items, and find an index of a particular value stored within the array list.
```
ArrayList arrayList = new ArrayList();
arrayList.Add(5);
arrayList.AddRange(new int[] { 6, -7, 8 });
arrayList.AddRange(new object[] { "Marcin", "Mary" });
arrayList.Insert(5, 7.8);
```
ArrayList can store multiple types of data; it means that you can store `integers`, `strings` etc. If you want to specify a type of each element, you can use the generic `List<T>`.
