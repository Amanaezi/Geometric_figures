using System;
using System.Collections.Generic;

namespace Geometric_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle() { A = 2, B = 5 });
            shapes.Add(new Circle() { R = 10 });
            shapes.Add(new Triangle() { H = 5, A = 2, B = 4, C = 7 });

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
