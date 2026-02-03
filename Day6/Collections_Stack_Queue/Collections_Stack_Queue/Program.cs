using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Stack_Queue
{
    internal class Program
    {
        //Common usecase of colelction ie   Stack and Queue in  reallife scenario are as below :
        //1. Stack : Undo mechanism in text editors , Browser history etc
        //2. Queue : Print spooling , CPU task scheduling , Call center systems etc
        //3. Priority Queue : Emergency room triage , Task scheduling in operating systems , Network packet routing etc
        //4. Deque : Browser history navigation , Undo/Redo functionality in applications , Task scheduling with varying priorities etc
        //5. Concurrent Collections : Real-time data processing , Multi-threaded web servers , Parallel computing tasks etc
        //6. list use cases : Data binding in UI frameworks , Implementing stacks and queues , Storing collections of items for processing etc



        //Step1: Define a stack to hold integer values ex.  
        //Step2: Push some values onto the stack
        //Step3: Pop a value from the stack and display it
        //Step4: Peek at the top value of the stack without removing it( All fucntinoality are provided by Stack class in System.Collections.Generic namespace)
        //Step5: Check if the stack contains a specific value( Searching functionality)
        //Step6: Display the current count of items in the stack(Using Count property of Stack class)
        //Step7: Clear the stack of all items(Using Clear method of Stack class)
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>(); //Stack that can hold integer values
            // Step 2: Push some values onto the stack
            stack.Push(10);// In list we were using Add() method to add values but in stack we use Push() method to add values
            stack.Push(20);
            stack.Push(30);
            // Step 3: Pop a value from the stack and display it
            int poppedValue = stack.Pop();
            Console.WriteLine("Popped Value: " + poppedValue);
            // Step 4: Peek at the top value of the stack without removing it
            int topValue = stack.Peek();
            Console.WriteLine("Top Value: " + topValue);
            // Step 5: Check if the stack contains a specific value
            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20: " + contains20);
            // Step 6: Display the current count of items in the stack
            int count = stack.Count;//this is same as other collection classes like List , Queue etc
            Console.WriteLine("Current Count: " + count);

            // Step 7: Clear the stack of all items
            stack.Clear();
            Console.WriteLine("Stack cleared. Current Count after clearing: " + stack.Count);

            //with the help of lambda expression we can write it in oneline like
            Func<int, bool> IsEven = number => number % 2 == 0;

            //IN a collection if we want to implemnt lanbda expressinoa to find a number greater than 10 
            List<int> numbers = new List<int> { 3, 5, 81, 45, 32, 15, 70 };
            // displaying elements of the list 
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            int result = numbers.Find(n => n > 10); //lambda expression C#3.0
            var evenNumber = numbers.Where(n => n % 2 == 0); //var is implicit type variable 
            Console.WriteLine("here are the list of even number in the house..");
            foreach (var item in evenNumber)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine(" here are the number greater than 10 in  list implemted via lambda expression" + result);



        }
    }
}
