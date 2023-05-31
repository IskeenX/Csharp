using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Triangle
    {
        // Fields

        private double a;
        private double b;
        private double c;

        // Constructor

        /// <summary>
        /// Create a triangle with 3 sides.
        /// </summary>
        /// <param name="a">side A</param>
        /// <param name="b">side B</param>
        /// <param name="c">side C</param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }


        public Triangle() // override the default constructor
        {
            Random r = new Random();
            do
            {
                a = r.Next(1, 101);
                b = r.Next(1, 101);
                c = r.Next(1, 101);
            } while (!RightTriangle());
        }

        // Methods

        private bool RightTriangle()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        /// <summary>
        /// Method for the perimeter.
        /// </summary>
        /// <returns>The result.</returns>
        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            // Heron formula
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
