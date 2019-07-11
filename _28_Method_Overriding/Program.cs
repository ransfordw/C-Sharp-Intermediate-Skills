using System;
using System.Collections.Generic;

namespace _28_Method_Overriding
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();

            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle(),
            };

            canvas.DrawShapes(shapes);

            Console.ReadKey();
        }
    }
}
