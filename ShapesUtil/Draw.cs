using System;
using static System.Console;


namespace ShapesUtil
{
    /// <summary>
    /// Class Draw to write a string in color
    /// </summary>
    public static class Draw
    {
        /// <summary>
        /// Prints out sample text in Cyan Color
        /// </summary>
        public static void Output()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("This is the output of Draw");
            ForegroundColor = ConsoleColor.White;
            
        }

        /// <summary>
        /// Prints out a given string in Cyan Color overloaded Function of Output
        /// </summary>
        /// <param name="String"></param>
        public static void Output(String str1)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(str1);
            ForegroundColor = ConsoleColor.White;
            

        }

        public static void Output(ConsoleColor c, String str1)
        {
            ForegroundColor = c;
            WriteLine(str1);
            ForegroundColor = ConsoleColor.White;
            
            
        }

    }
}
