using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
     public abstract class Shape
    {
        public float sideA;
        public float sideB;
        public float height;

        public Shape(float a, float b, float h)
        {
            sideA = a; 
            sideB = b; 
            height = h;
        }
        public Shape(float a, float b)
        {
            sideA = a;
            sideB = b;
        }
        public Shape(float a)
        {
            sideA = a;
        }
        public Shape() { }

        public abstract float Area();
        public abstract float Perimeter();

        public static float GetArea(Shape shape)
        {
            return shape.Area();
        }
        public static float GetPerimeter(Shape shape)
        {
            return shape.Perimeter();
        }
    }
}