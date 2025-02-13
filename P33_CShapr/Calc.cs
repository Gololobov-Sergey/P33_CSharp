using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public delegate double CalcDelegate(int a, int b);       
    
    internal class Calc
    {
        public double Sum(int a, int b) => a + b;
        public double Diff(int a, int b) => a - b;
        public static double Mult(int a, int b) => a * b;
        public double Div(int a, int b) => a / b;
    }
}
