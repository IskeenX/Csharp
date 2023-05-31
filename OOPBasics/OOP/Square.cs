using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Square
    {
        // Fields

        private int x;
        private int y;
        private int width;
        private int height;

        // Constructor

        public Square()
        {
            Random r = new Random();
            this.x = r.Next(1, 21);
            this.y = r.Next(1, 21);
            this.width = r.Next(1, 11);
            this.height = r.Next(1, 11);
        }

        public Square(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
