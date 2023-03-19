using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(5, 7, 9);
            //t1.a = 5;
            //t1.b = 7;
            //t1.c = 9;
            Console.WriteLine("Perimeter: " + t1.Perimeter());
            Console.WriteLine("Area: " + t1.Area());

            Triangle t2 = new Triangle();
            Console.WriteLine("Perimeter: " + t2.Perimeter());
            Console.WriteLine("Area: " + t2.Area());

            Student[] students = new Student[3];
            students[0] = new Student("John Smith", "TZU456", 22);
            students[1] = new Student();
            students[2] = new Student("Big Bob", "4TGD4A", 20);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].PrintOut());
            }
            Console.ReadKey();
        }

        static string OldestStudent(Student[] students)
        {
            int max = 0;
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].age > students[max].age)
                {
                    max = i;
                }
            }

            return students[max].PrintOut();
        }
    }
}
