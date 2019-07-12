using System;

namespace _29_Abstract_Classes_And_Members
{
    partial class Program
    {
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Rectangle.");
            }
        }

    }
}
