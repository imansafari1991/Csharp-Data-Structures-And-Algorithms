﻿using Arrays.Contracts;
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
            ArraysDemo();
            Test1BasedArray();


            // 
        }
        private static void ArraysDemo()
        {
            var a = 3;
            var b = 4;
            (a, b) = (b, a);

            // null refrence array not allocated memory
            int[] a1;
            // allocate 10 integer in memory
            a1 = new int[10];

            int[] a2 = new int[5];
            // Different way to instantiate an array 
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            //System.Array

            // The ways of iterating an array
            for (int i = 0; i <= a3.Length - 1; i++)
            {
                Console.Write($"{a3[i]}");
            }

            Console.WriteLine();

            foreach (var el in a4)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine();

          
            // Different way to initiate an array
            // This method give us some new capabilities to work with array like Binary search , ...
            Array myArray = new int[5];
            // Creates a one-dimensional System.Array of the specified System.Type (int) and length (5)
            Array myArray2 = Array.CreateInstance(typeof(int), 5);

            // Creates a two-dimensional System.Array of the specified System.Type and dimension lengths, with zero-based indexing.
            Array twoDArray =Array.CreateInstance(typeof(int), 5,5);

            // Creates a three-dimensional System.Array of the specified System.Type and dimension lengths, with zero-based indexing.
            Array threeDArray =Array.CreateInstance(typeof(int), 5,6,6);

            // Creates a multidimensional System.Array of the specified System.Type and dimension lengths, with zero-based indexing. The dimension lengths are specified in an
            // array of 32-bit integers.
            Array nDArray =Array.CreateInstance(typeof (int), new int[] {2,3,4,5,1,2,3});

            // Creates a multidimensional System.Array of the specified System.Type and dimension
            //lengths, with the specified lower bounds.
            Array nDArrayNonZeroBased = Array.CreateInstance(typeof(int), new int[] { 2, 3, 4 },new int[] {1,3,2});



            // Reverse

            // Reverses all elements of the given array. Following a call to this
            // method, an element previously located at index i will now be
            // located at index length - i - 1, where length is the
            // length of the array.
          
            Console.WriteLine($"a3 array is:{string.Join(',',a3)}");
            Array.Reverse(a3);
            Console.WriteLine($"reverse of a3 array is:{ string.Join(',', a3)}");
             
             int[] a5 = { 1, 2, 3, 4, 5,6,7,8,9,10 };

            // Reverses the elements in a range of an array. Following a call to this
            // method, an element in the range given by index and count
            // which was previously located at index i will now be located at
            // index index + (index + count - i - 1).
            // Reliability note: This may fail because it may have to box objects.
            //Reverse array from `index` at size of `length`
            Console.WriteLine($"a5 array is:{string.Join(',',a5)}");
            Array.Reverse(a5,3,4);
            Console.WriteLine($"a5 reverse array is:{string.Join(',', a5)}");


            myArray2.SetValue(1, 0);

            Console.Read();

            var s = "Hello world iman    ";
          var dd=  s.Split(" ").Last(p => !string.IsNullOrWhiteSpace(p));
        }
        private static void Test1BasedArray()
        {
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 ,4}, new[] { 1 ,2});

            myArray.SetValue(2019,new int[] {2,3});
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            Console.WriteLine($"Starting index:{myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index:{myArray.GetUpperBound(0)}");

            //for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
        }
    }
}
