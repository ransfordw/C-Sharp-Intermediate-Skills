using System;

namespace _24_Upcasting_And_Downcasting
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Conversion from a derived class to a base class (upcasting)
            // Conversion from a base class to a derived class (downcasting)
            // as and is keywords

            Text text = new Text();
            Shape shape = text; // both are references to the same object in memory, but with different views
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);
            Console.ReadKey();
             

        }
    }
}
