using System;
using ConsoleApp;

/*Why do we need Functions in C#?

Functions (also called methods) are needed in C# to divide a program into small, reusable, and manageable parts.
Instead of writing the same logic again and again, we write it once inside a function and call it whenever required.

Advantages of Functions

Code Reusability – same function can be used multiple times

Better Readability – program becomes easy to understand

Easy Maintenance – changes are made at one place

Modular Programming – large problems are broken into smaller tasks

Reduces Errors – logic is written and tested once*/

//A school needs a program to:
//1. Calculate Total Marks
//2. Calculate Average Marks
//3. Determine Pass or Fail
//class SchoolResult is created to implement these functionalities using functions and then call them from Main method.

class Program
{
    static void Main(string[] args)
    {
        mainFunction();// calling main function so that program runs and it calls other functions
        //creating instance of class CarParking so that program runs
        CarParking delhiparking = new CarParking();
        delhiparking.Run(); // calling Run method to start the parking application rest of the code is in CarParking.cs
        // which will be executed auomatically

        Console.WriteLine("Implementing fucntions ");
    }

    static int calculateTotal(int marks1, int marks2, int marks3)
    {
        return marks2 + marks1 + marks3;
    }

    //fucntion to calcuate average
    static double calculateAverage(int totalMarks, int numberOfSubjects = 3) // default parameter
    {
        return (double)totalMarks / numberOfSubjects;
    }
    //fucntion to check result 
    static string checkResult(double averageMarks, double passMark = 40.0) // default parameter
    {
        if (averageMarks >= passMark)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

    //creating main function to call other functions
    static void mainFunction()
    {
        int marks1 = 5;
        int marks2 = 8;
        int marks3 = 92;
        int totalMarks = calculateTotal(marks1, marks2, marks3);// function call
        double averageMarks = calculateAverage(totalMarks);
        string result = checkResult(averageMarks);

        Console.WriteLine("below is the result ...!!");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks}");
        Console.WriteLine($"Result: {result}");
    }
}