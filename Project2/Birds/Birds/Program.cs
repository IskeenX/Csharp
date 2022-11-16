using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of birds and size of table:");
            string[] indexes = Console.ReadLine().Split(';');
            Forest forest = new Forest(int.Parse(indexes[0]), int.Parse(indexes[1]), int.Parse(indexes[1])); 
            forest.ForestSize();

            Console.ReadLine();
        }
    }
}
