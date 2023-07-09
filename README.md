# Data-Structures-And-Algorithms

# Data types

While developing applications in the C# language, you could use various data types, which are divided into two groups, namely **value types** and **reference types**. 
The difference between them is very simple—a variable of a value type directly contains data, while a variable of a reference type just stores a reference to data, as shown as follows:
As you can see, a Value type stores its actual Value directly in the Stack memory, while a Reference type only stores a Reference here. The actual value is located in the Heap memory. Therefore, it is also possible to have two or more variables of a reference type that reference exactly the same value.




# Arrays
When you want to store a set of variables you can use Arrays. When you face arrays you sometimes need to **Sort** them. There are some familiar sorting algorithms such as :
selection sort, insertion sort, bubble sort, and quicksort.

## Selection sort
Selection sort is the simplest sorting algorithm. The algorithm divides the array into two parts, namely **sorted** and **unsorted**. In the following iterations, the algorithm finds the **smallest** element in the unsorted part and exchanges it with the first element in the unsorted part. Before writing code let's start with sorting an array with nine elements [-11, 12, -42, 0, 1, 90, 68, 6, -9].

![image](https://github.com/imansafari1991/Csharp-Data-Structures-And-Algorithms/assets/52294855/915d61e9-0f5e-4be8-a977-707bcfd8d274)

At the first step of algorithm **(i=0)** we consider the sorted part of the array is empty. We consider the i*th* index of the array as the minimum value. Try to sweep at the rest elements of the array with the *m* index that starts from **i+1** and find the minimum value of the array by comparing each element with minValue. In each iteration, compare the value of the element with minValue, and substitute it with minValue 

