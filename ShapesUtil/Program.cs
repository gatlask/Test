using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// this is a Shaped utility program to test various options available in c#
/// Classes, Objects, OOPs, abstraction, Enums etc
/// </summary>
namespace ShapesUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to the program to test various options in C#");
            Console.WriteLine("This program explores the various shapes available");

            //adding a Draw Class
            //this class just changes the output color of console write for now
            Draw.Output();

            //Creating a Shape Object
            Shape Shp1 = new Shape();

            //Calling method Draw shape in the shape
            Shp1.DrawShape();

            //using an inherited class Multiple inheritance with Interfaces
            Rectangle rect1 = new Rectangle();

            rect1.DrawShape();
            Draw.Output(rect1.ShapeName);
            Draw.Output($"the Dimensions is {rect1.Dim}");
            //types specific to Rectangle
            Draw.Output($"{rect1.len} and {rect1.breadth}");

            // constructor chaining 
            Rectangle rect2 = new Rectangle(10, 5);

            Draw.Output(ConsoleColor.Yellow, $"{rect2.len} and {rect2.breadth}");

            //object Type
            // Universal Data Container
            object object1 = "Hello "; //object is a universal data container
            object1 = 5;
            object1 = 'o';

            //Nullable Type, extra declaration to store null value
            // or value not defined Nullable types are reference types 
            //i.e. they are reference to an object in the dynamic memory, which contains their actual value.
            Nullable<int> i1 = null;
            int? i2 = i1;

            Console.WriteLine(i2.HasValue);

            i2 = 5;

            i1 = i2.Value;
            i1 = i2.GetValueOrDefault();

            Console.WriteLine(i1);

            // variable declaration
            // Declare and initialize some variables
            byte centuries = 20;
            ushort years = 2000;
            decimal decimalPI = 3.141592653589793238m;
            bool isEmpty = true;
            char ch = 'a';
            string firstName = "John";
            ch = (char)5;
            char secondChar;

            object obj = 42;
            string str = "Hello";
            byte[] bytes = { 1, 2, 3 };

            //Literals
            //Integer Literals
            // sequence of integers followed by suffixes or prefixes
            int numberInDec = 16; int numberInHex = 0x10;
            //double, float , decimal ... etc

            //Character Literals
            // An ordinary character
            char character = 'a'; Console.WriteLine(character);
            // Unicode character code in a hexadecimal format
            character = '\u003A'; Console.WriteLine(character);
            // Assigning the single quotiation character (escaped as \')
            character = '\''; Console.WriteLine(character);
            // Assigning the backslash character (escaped as \\)
            character = '\\'; Console.WriteLine(character);
            // Console output: 
            // a 
            // : 
            // ' 
            // \

            //String Literals
            string quotation = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotation);
            string path = "C:\\Windows\\Notepad.exe";
            Console.WriteLine(path);
            string verbatim = @"The \ is not escaped as \\.
                    I am at a new line.";
            Console.WriteLine(verbatim);

            // Console output: 
            // "Hello, Jude", he said. 
            // C:\Windows\Notepad.exe 
            // The \ is not escaped as \\. 
            // I am at a new line.

            int c = CalcAdd(5, 10);
            Draw.Output(ConsoleColor.Red, $"{c}");
            Draw.Output((ConsoleColor)10, $"{c}");

            //method with variable no of paramenters
            long sum = CalcSum(2, 5);
            Console.WriteLine(sum);
            long sum2 = CalcSum(4, 0, -2, 12);
            Console.WriteLine(sum2);
            long sum3 = CalcSum();
            Console.WriteLine(sum3);
            Console.ReadKey();

            Draw.Output(ConsoleColor.Magenta, "The next part prints a number triangle with help of methods");
            PrintTriangle(10);

            Console.WriteLine($"{Fib(10)}");
            Console.ReadKey();

            // nested loops

            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);

            Console.ReadKey();

        }

        // static method with Parameters
        public static int CalcAdd(int a, int b)
        {
            return (a + b);
        }

        // multiple paraments
        static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return sum;
        }


        static void PrintTriangle(int n)
        {
            // Printing the upper part of the triangle

            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //recursion

        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);

        }


        // Nested Loops Recursive methods

        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;

                NestedLoops(currentLoop + 1);
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }

}

