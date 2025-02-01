using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P33_CShapr
{
    public abstract class Human
    {
        protected int id;
        string name;
        int age;

        public Human()
        {
            
        }

        public Human(string n, int a)
        {
            name = n;
            age = a;
        }

        //public virtual void Info()
        //{
        //    Console.WriteLine($"Name : {name}");
        //    Console.WriteLine($"Age  : {age}");
        //}

        public override string ToString()
        {
            return $"Name : {name}\nAge  : {age}";
        }

        public virtual int getId()
        {
            return id;
        }

        public abstract void WhoAmI();
    }

    public /*sealed*/ class Employee : Human
    {
        new int id;
        int salary;

        public Employee(string n, int a, int s) : base(n, a)
        {
            salary = s;
        }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Salary: {salary}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {salary}";
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I`m Employee");
        }
    }

    public class Director : Employee, IWorker
    {
        int countEmployee;
        public Director(string n, int a, int s, int ce) : base(n, a, s)
        {
            countEmployee = ce;
        }

        public int Salary { get; set; }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Count Employee: {countEmployee}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nCount Employee: {countEmployee}";
        }

        public void Work()
        {
            Console.WriteLine("I`m working Direcror");
        }
    }


    public class Economist : Employee, IWorker
    {
        int seniority;

        public Economist(string n, int a, int s, int se) : base(n, a, s) 
        {
            seniority = se;
        }

        public int Salary { get ; set; }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Seniority: {seniority}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nSeniority: {seniority}";
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


    public class CleaningManager : Employee
    {
        int area;

        public CleaningManager(string n, int a, int s, int ar) : base(n, a, s) 
        {
            area = ar;
        }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Area: {area}");
        //}


        public override string ToString()
        {
            return base.ToString() + $"\nArea: {area}";
        }
    }
}
