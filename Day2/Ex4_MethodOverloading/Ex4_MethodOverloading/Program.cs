// See https://aka.ms/new-console-template for more information
/*Method Overloading in C# is the ability to define multiple methods with the same name but different parameter lists.

Parameter lists can differ by type, number or order of parameters.
Improves readability and lets related tasks use the same method name.
Cannot overload methods by only changing the return type (causes compile-time error).
Also known as compile-time (static) polymorphism.
Different Ways of Method Overloading
Method overloading can be done by changing:

1.Changing the number of Parameters
2.Changing data types of the parameters.
3.Changing the Order of the parameters.*/


using System;

class overloading
{
    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    public static void Main(String[] args)
    {
        overloading ob = new overloading();

        int sum1 = ob.Add(1, 2);
        Console.WriteLine("add() with two integers");
        Console.WriteLine("sum: " + sum1);

        Console.WriteLine("add() with three integers");
        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum: " + sum2);
    }
}
