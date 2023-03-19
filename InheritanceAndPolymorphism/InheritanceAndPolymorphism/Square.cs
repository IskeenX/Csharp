using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Square : Rectangle
    {
        public Square(float a) : base(a) 
        {
            ToString();
        }

        public override float Area()
        {
            float areaS = sideA * sideA;
            return areaS;
        }
        public override float Perimeter()
        {
            float perS = sideA * 4;
            return perS;
        }

        public override string ToString()
        {
            float area = Area();
            float perimeter = Perimeter();
            return $"This is a square with perimeter {perimeter} and area {area}.";
        }
    }
}