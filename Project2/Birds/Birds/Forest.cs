using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Forest
    {
        //Fields
        private int width;
        private int height;
        private int num;
        public int count;
        //Constructors
        public Forest(int num, int width, int height)
        {
            this.num = num;
            this.width = width;
            this.height = height;
        }
        //Method
        public void ForestSize()
        {
            //Coordinates of each bird
            string[] cord = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Input X, Y and radius of bird {i + 1}: ");
                cord[i] = Console.ReadLine();
            }
            //Whole forest
            count = height * width;
            string[,] arr = new string[height, width];
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    arr[i, j] = "0";
                }
            }
            //Birds input
            for (int k = 0; k < num; k++)
            {
                string[] cord1 = cord[k].Split(';');
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if(i >= int.Parse(cord1[0]) - 1 - int.Parse(cord1[2]) && i <= int.Parse(cord1[0]) - 1 + int.Parse(cord1[2]) &&
                           j >= int.Parse(cord1[1]) - 1 - int.Parse(cord1[2]) && j <= int.Parse(cord1[1]) - 1 + int.Parse(cord1[2]))
                        {
                            if (arr[i, j].Equals("0"))
                            {
                                arr[i, j] = Convert.ToString(k + 1);
                                count -= 1;
                            }
                            else
                            {
                                arr[i, j] += Convert.ToString(k + 1);
                            }
                        }
                    }
                }
            }
            //Output
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(count);
        }
    }
}
