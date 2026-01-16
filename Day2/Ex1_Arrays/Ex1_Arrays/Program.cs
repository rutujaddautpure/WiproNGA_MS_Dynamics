// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
//features of arrays in C#:
//1. Fixed Size: Once an array is created, its size cannot be changed.( Collections like List<T> can be used for dynamic sizing)
//2. Zero-Based Indexing: The first element of an array is accessed with index 0.
//3. Homogeneous Elements: All elements in an array must be of the same data type.if they are not , type casting is required. collection 
//4. Multi-Dimensional Arrays: C# supports multi-dimensional arrays (e.g., 2D arrays, 3D arrays).
//5. Array Methods: C# provides various built-in methods for arrays, such as Sort(), Reverse(), and IndexOf().
//6. Array Properties: Arrays have properties like Length, which returns the number of elements in the array.
//7. Array Initialization: Arrays can be initialized at the time of declaration using curly braces {}.

//Steps for creating Arrays in C#
//Step 1: Declare the array of type int 
//Step 2: Initialize the array with size 5
//Step 3: Assign values to each index of the array
//Step 4: Print the values of the array using a for loop

//When we should use arrays in C#?
//1. Fixed Size Requirement: When the number of elements is known and does not change frequently.
//2. Performance: Arrays provide fast access to elements using indices, making them suitable for performance-critical applications.
//3. Homogeneous Data: When all elements are of the same type, arrays provide a simple and efficient way to store and manipulate data.
//4. Multi-Dimensional Data: When dealing with grid-like data structures, such as matrices or tables.

//some common use cases of arrays in C#:
//1. Storing a list of items, such as product names or IDs.
//2. Implementing mathematical matrices for calculations.
//3. Managing collections of data, such as student grades or employee records.
class Program
{
    static void Main()
    {
        // Declare and initialize an array
        int[] numbers = { 01, 02, 03, 04, 05 };
        string[] names = { "Rutuja", "Tina", "Shruti" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();
        // Access array elements using a loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
            //sorting array
            Array.Sort(numbers);


        }
        Console.WriteLine();
        //Getting started with 2D Arrays in C#
        // this is the implenementation of 2D array
        Console.WriteLine("2d array");
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        // Access and print elements
        for (int i = 0; i < matrix.GetLength(0); i++) // rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        /* getting started with jagged arrays in C#
        jagged Arrays in C# : where each element is an array itself ex
        Arrays  of arrays , specific rows can have different number of columns
        Biggest benefit : memory efficiency when dealing with non-uniform data ex
         a table where each row represents a different entity with varying attributes in case of e commerce products
        Step 1: Declare a jagged array
        Step 2: Initialize each row with different sizes
        Step 3: Print the values of the jagged array using nested for loops
        hence we use jagged arrays when we have non uniform data to save memory over a 2D array,
        where all rows must have same number of columns
        jagged arrays are arrays of arrays, where each "row" can have a different length.*/
        Console.WriteLine("jagged array");
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        // Access and print elements of jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
