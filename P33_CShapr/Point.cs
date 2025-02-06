using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static Point operator -(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y };
        }

        public static Point operator +(Point p)
        {
            return new Point() { X = 2 * p.X, Y = 2 * p.Y };
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }

        public static Point operator +(Point p1, Int32 n)
        {
            return new Point() { X = p1.X + n, Y = p1.Y + n };
        }

        public static Point operator +(int n, Point p1)
        {
            return new Point() { X = p1.X + n, Y = p1.Y + n };
        }

        public static Boolean operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static Boolean operator !=(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static Boolean operator ==(Point p1, int p2)
        {
            return true;
        }

        public static Boolean operator !=(Point p1, int p2)
        {
            return true;
        }

        public static Boolean operator ==(int p, Point p1)
        {
            return true;
        }

        public static Boolean operator !=(int p, Point p1)
        {
            return true;
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }


        public static Point operator &(Point p1, Point p2)
        {
            return new Point();
        }

        public static explicit /*implicit*/ operator double (Point p)
        {
            return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
        }

        public static explicit /*implicit*/ operator float(Point p)
        {
            return (float)Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
        }

        public int this[string index]
        {
            get
            {
                if (index == "X")
                    return X;
                if (index == "Y")
                    return Y;
                return 0;
            }
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
