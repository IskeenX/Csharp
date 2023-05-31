using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Trapezoid : Shape
    {
        public Trapezoid(float a, float b, float h) : base(a, b, h)
        {
            ToString();
        }
        public Trapezoid(float a, float b) : base(a, b) { }
        public Trapezoid(float a) : base(a) { }

        public override float Area()
        {
            float areaT = (sideA + sideB) / 2 * height;
            return areaT;
        }
        public override float Perimeter() { return 0; }

        public override string ToString()
        {
            float area = Area();
            return $"This is a trapezoid with area {area}";
        }
    }
}