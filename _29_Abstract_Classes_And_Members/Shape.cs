using System;

namespace _29_Abstract_Classes_And_Members
{
    partial class Program
    {
        public abstract class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public abstract void Draw();
            public void Copy()
            {
                Console.WriteLine("Copy shape into clipboard.");
            }

            public void Select()
            {
                Console.WriteLine("Highlight the shape.");
            }
        }
    }
}
