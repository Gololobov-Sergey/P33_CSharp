using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public struct Point
    {
        public int X = 55;
        public int Y;

        public Point(int x, int y)
        {
            X = x; 
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
}
