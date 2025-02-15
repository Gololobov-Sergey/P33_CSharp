using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public class Point2D<T> where T : /*struct,*/ /*class,*/ /*Human*/   IComparable<T> /*Interface,*/  /*new()*/
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D()
        {
            X = default;
            Y = default;
        }

        public Point2D(T x, T y)
        {
            X = x; 
            Y = y;
        }
    }


    public class Point3D : Point2D<double>
    {

    }

    class Test<T> : Student
    {

    }
}
