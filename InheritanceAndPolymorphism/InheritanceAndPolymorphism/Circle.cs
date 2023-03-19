using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Circle : Shape
    {
        private float radius;

        public Circle(float r)
        {
            radius = r;
        }

        public override float Area()
        {
            float areaC = (float)Math.PI * (float)Math.Pow(radius, 2);
            return areaC;
        }
        public override float Perimeter()
        {
            float perC = (float)Math.PI * 2 * radius;
            return perC;
        }

        public override string ToString()
        {
            float area = Area();
            float perimeter = Perimeter();
            return $"This is a circle with perimeter {perimeter} and area {area}.";
        }
    }
}
