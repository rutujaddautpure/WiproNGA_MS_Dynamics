// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefined_Types
{
    //Step 1: Create an Enum to represent OrderStaus with values Pending, Processing, Shipped, Delivered, Cancelled
    //Step 2: Create a stucture to represent Location with properties Latitude and Longitude of type double
    //Step 3: Create a interface for payment contract with methods ProcessPayment and RefundPayment, makePayment(double amount)
    interface IPayment
    {
        void ProcessPayment(double amount);
        void RefundPayment(double amount);
        bool MakePayment(double amount);
    }

    //creating a class to implement the payment interface
    //ex creditcard payment AND debit card payment
    //Step 4: Class to represent Order with properties OrderId, OrderStatus (use enum), ShippingLocation (use struct), and implement payment interface.



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    //types in C#.NET
    //on the basisi of value and ref type
    //On the basisi  of predefined and user defined types

    //Primitive Types - int, float, double, char, bool, byte, short, long, decimal
    //Use case of Primitive Types is to store simple values like numbers, characters, and boolean values.
    //memeory size is generally small and fixed. it is on Stack. faster access.


    //User define types - Class, Struct, Enum, Interface, Delegate
    //Use case of User Define Types is to create complex data structures and define custom behaviors.
    //memory size is generally larger and variable. it is on Heap. slower access.

    //One way to decide which type is ideal for what use case is to consider the following factors:
    //1. Complexity of Data - ex : if you need to store multiple related values, a class or struct is more suitable than primitive types.
    //enum is best suited for a fixed set of related constants. ex gaming sceanrio - directions, levels, character types. or colors.
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }
    //struct is best suited for small, lightweight data structures that have value semantics.
    //ex : point in 2D space, complex number, RGB color.
    // Ecommerce application - struct for representing a product with properties like ID, Name, Price, and Quantity.
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    //class is best suited for larger, more complex data structures that require reference semantics.
    //ex : customer, order, employee.
    //Interface is best suited for defining contracts and abstractions without implementation.
    //Delegate is best suited for defining method signatures for callback and event handling scenarios.
    //ex common ex of delegate is event handling in Mobile apps or GUI applications.
    //where you define a delegate for button click events, and different methods can be assigned to handle the event.


    //2. Behavior and Functionality - ex : if you need to define methods and behaviors, a class or interface is more appropriate
    //3. Memory Management - ex : if you need to manage memory explicitly, a struct may be more suitable than a class.

    //Why structure are better than class in terms of memory management ?
    //they are stored on stack memory which is faster to allocate and deallocate compared to heap memory used by classes.
    //maximum memeory size of struct is 16 bytes. if it exceeds it will be stored on heap memory.
    // all elements of struct  try to use contiguous memory locations which improves cache locality and access speed.


    //4. Performance Considerations - ex : if performance is critical, a struct may be more efficient due to its value type semantics.
    //delegates can provide better performance for callback scenarios compared to using interfaces or classes.
    //delegate are also known as type safe function pointers.
    //We can not not work with pointers directly in C# as we do in C or C++.

    // Do we have any way of working with pointers in C# so that they are type safe : yes we have delegates

    //5. Interoperability - ex : if you need to interact with unmanaged code or APIs, a struct may be more suitable due to its fixed memory layout.

    //In .NET we can define pointer types using the "unsafe" keyword. where .NET allows you manage memory directly using pointers.
    //a pointer is a variable that stores the memory address of another variable.
    //in .NET we use term "unsafe" to indicate that the code block or method contains pointer operations.
    //where .NET ( CLR) is not reiponsible for memory management and it is the developer's responsibility to ensure memory safety.
}
