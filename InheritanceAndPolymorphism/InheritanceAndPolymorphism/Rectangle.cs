using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Rectangle : Trapezoid
    {
        public Rectangle(float a, float b) : base(a, b)
        {
            ToString();
        }
        public Rectangle(float a) : base(a) { }

        public override float Area()
        {
            float areaR = sideA * sideB;
            return areaR;
        }
        public override float Perimeter()
        {
            float perimeterR = (sideA + sideB) * 2;
            return perimeterR;
        }

        public override string ToString()
        {
            float area = Area();
            float perimeter = Perimeter();
            return $"This is a rectangle with perimeter {perimeter} and area {area}.";
        }
    }
}