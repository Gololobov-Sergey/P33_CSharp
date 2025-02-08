using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public interface IWorker
    {
        void Work();
        int Salary {  get; set; }
    }


    public interface IA
    {
        void Show();
        //
        //
    }

    public interface IB
    {
        void Show();
        //
        //
    }

    public interface IC
    {
        void Show();
        //
        //
    }


    public class Test : IA, IB, IC
    {
        public void Show()
        {
            Console.WriteLine("Show");
        }

        //
        //
        void IA.Show()
        {
            Console.WriteLine("Show A");
        }

        void IB.Show()
        {
            Console.WriteLine("Show B");
        }

        //void IC.Show()
        //{
        //    Console.WriteLine("Show C");
        //}
    }

}
