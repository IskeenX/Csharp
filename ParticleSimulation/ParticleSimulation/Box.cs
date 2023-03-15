using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    internal class Box
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Show() //display of box
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int x = 0; x < Width+2; x++) //rows
            {
                Console.SetCursorPosition(x, 0);
                Console.Write(" ");
                Console.SetCursorPosition(x, Height+1);
                Console.Write(" "); 
            }
            for (int y = 1; y < Height+2; y++) //columns
            {
                Console.SetCursorPosition(0, y);
                Console.Write(" ");
                Console.SetCursorPosition(Width+1, y);
                Console.Write(" ");
            }
            Console.ResetColor();
        }
    }
}
