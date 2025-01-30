using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P33_CShapr
{
    public class Human
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

        public void Info()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
        }
    }

    public /*sealed*/ class Employee : Human
    {
        new int id;
        int salary;

        public Employee(string n, int a, int s) : base(n, a)
        {
            salary = s;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Salary: {salary}");
        }
    }

    public class Director : Employee
    {
        public Director(string n, int a, int s) : base(n, a, s)
        {
            
        }
    }
}
