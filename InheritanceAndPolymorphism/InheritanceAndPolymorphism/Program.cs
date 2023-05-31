using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = (float)10.5;
            float b = (float)14.2;
            float h = (float)6.4;
            float r = (float)8.3;
            int max = 0;
            int count = 0;

            Shape[] shapes = { new Trapezoid(a, b, h), new Rectangle(a,b), new Square(a), new Circle(r) };
            float[] array = new float[shapes.Length];
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i]);
            }
            foreach (Shape shape in shapes)
            {
                array[count] = Shape.GetArea(shape);
                count++;
            }
            Console.WriteLine();
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            Console.WriteLine(shapes[max].ToString());

            Console.ReadKey();
        }
    }
}