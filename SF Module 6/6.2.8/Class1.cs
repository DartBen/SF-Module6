using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._8
{
    internal class Rectangle
    {
        int a, b;

        public int Square() { return a * b; }

        public Rectangle(int x)
        {
            a = x;
            b = x;
        }

        public Rectangle(int x, int z)
        {
            a = x;
            b = z;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

    }
}
