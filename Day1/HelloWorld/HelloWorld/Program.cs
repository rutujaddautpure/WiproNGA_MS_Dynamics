using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//All these using directives are added by default in a new console application project.
//Framework class library references.

namespace HelloWorld
// Namespace declaration is used for organizing code and preventing name conflicts.
{
    internal class Program
    // Class declaration. 'internal' means it is accessible only within its own assembly.
    // in C# we have following visibility Scope: 
    // public, private, protected, internal, protected internal, private protected
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Console.WriteLine is used to print text to the console.
        }
    }
}
