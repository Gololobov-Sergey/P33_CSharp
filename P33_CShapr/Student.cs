using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public class Student : IWorker
    {
        public string name = "Alex";

        public string group = "P33";

        static int course;

        public const int maxRate = 12;

        public readonly int[] mark;

        readonly int id;

        //int age;


        private int age;

        public int Age
        {
            get 
            { 
                return age; 
            }
            set 
            {
                if (value > 110)
                    return;
                age = value; 
            }
        }


        public int MyProperty { get; set; } = 120;
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Student(int id) : this(id, "")
        {
           
        }

        public Student(int id, string name )
        {
            this.id = id;
            this.name = name;
        }

        static Student()
        {
            course = 1;
        }


        //public int GetAge()
        //{
        //    return age;
        //}

        //public void SetAge(int age)
        //{
        //    //
        //    this.age = age;
        //}

        public int GetID()
        { 
            return id; 
        }

        public Student Method()
        {
            name = "999";
            return this;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + group);
        }

        public static int GetCourse()
        {
            return course++;
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    public partial class First
    {
        public int id;
        public string name;
        public bool flag;
        public float number;

        public First(int a)
        {
            
        }

        public void Print()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(flag);
        }
    }
}
