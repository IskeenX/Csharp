using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student
    {
        // Fields

        private string name;
        private string neptun;
        public int age; // for the OldestStudent method

        // Constructor

        public Student()
        {
            name = "Anonymous";
            neptun = "AAA111";
            age = -1;
        }

        public Student(string name, string neptun, int age)
        {
            this.name = name;
            this.neptun = neptun;
            this.age = age;
        }

        public string PrintOut()
        {
            return "Name: " + name + ", Neptun code: " + neptun + ", age: " + age;
        }
    }
}
