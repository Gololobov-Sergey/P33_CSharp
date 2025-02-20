using System.Collections;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;

namespace P33_CShapr
{
    internal class Program
    {

        enum Direction : ulong
        {
            Left, Right = 5000000000000, Top, Bottom
        }

        static void Test(ref int a, ref int[] arr, out int b)
        {
            b = 555;

            Console.WriteLine(a);
            foreach (int i in arr)
                Console.Write(i + ", ");
            Console.WriteLine();

            a = 999;
            arr[0] = 9999;
            arr = new int[] { 1, 2, 3 };

            Console.WriteLine();

            Console.WriteLine(a);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void PrintSalary(IWorker employee)
        {
            Console.WriteLine(employee.Salary);
        }

        static void Test()
        {
            Console.WriteLine("Test");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        public delegate void VoidDelegate();

        public static T MaxElem<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public delegate T TDelegate<T>(T a, T b);

        public delegate T3 TDelegate1<T1, T2, T3>(T1 a, T2 b);

        static public void Print(int a)
        {
            Console.Write(a + " ");
        }

        static public bool IsEven(int a)
        {
            return a > 0;
        }

        static public decimal AvgDate(Student st)
        {
            return (decimal)(DateTime.Now - st.BirthDay).TotalDays / 365.25M;
        }

        static public bool BirthMay(Student st)
        {
            return st.BirthDay.Month == 5;
        }

        static public int FromMonth(Student st)
        {
            return st.BirthDay.Month;
        }

        static public void PrintStudent(Student st)
        {
            Console.WriteLine(st);
        }

        static public int SortFromDate(Student s1, Student s2)
        {
            return s1.BirthDay.CompareTo(s2.BirthDay);
        }

        public static void Swap<T>(ref T one, ref T two)
        {
            (one, two) = (two, one);
        }

        public static (int, int) F(int a, int b)
        {
            return (b, a);
        }

        static void Main(string[] args)
        {
            Console.Title = "P33 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();


            Console.WriteLine("Слава Україні!");


            /// 20.02.2025 ///
            /// /////////////
            /// 

            List<Student> students = new List<Student>
            {
                new Student
                {
                    LastName = "Orlov",
                    FirstName = "Kirill",
                    BirthDay = new DateTime(2000, 5, 10),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123456
                    }
                },

                new Student
                {
                    LastName = "Petroff",
                    FirstName = "Oleg",
                    BirthDay = new DateTime(1999, 4, 20),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123455
                    }
                },

                new Student
                {
                    LastName = "Fedorova",
                    FirstName = "Maria",
                    BirthDay = new DateTime(2001, 10, 12),
                    StudentCard = new StudentCard
                    {
                        Series = "AC",
                        Number = 123456
                    }
                },

                new Student
                {
                    LastName = "Avdeeva",
                    FirstName = "Olga",
                    BirthDay = new DateTime(2001, 5, 5),
                    StudentCard = new StudentCard
                    {
                        Series = "AA",
                        Number = 123456
                    }
                }
            };

            //Teacher teacher = new Teacher { FullName = "Gololobov S.A." };
            //foreach (Student item in students)
            //{
            //    teacher.ExamEvent += item.Exam;
            //}

            //ExamEventArgs exam = new ExamEventArgs { Date = new DateTime(2025, 2, 20), Subject = "C#", Room = 208 };

            //teacher.SetExam(exam);

            //teacher.ExamEvent -= students[2].Exam;

            //Console.WriteLine();

            //exam.Date = new DateTime(2025, 4, 30);
            //teacher.SetExam(exam);


            CreditCard cc = new CreditCard { PIN = "0000" };
            cc.ChangePIN += informToTelegram;
            cc.ChangePIN += informToEmail;

            cc.PIN = "5552";
            

            //teacher.ExamEvent += Teacher_ExamEvent;


            /// 15.02.2025 ///
            /// /////////////
            /// 

            //Stack<int> st = new Stack<int>();

            //Point2D<Student> p = new Point2D<Student>();

            //TDelegate1<int, float, string> f;
            //TDelegate1<int, DateTime, Student> f1;

            //List<int> arr = [ 1, 2, 45, 6, 9, 9, 7, 5, 3 ];
            //arr.ForEach(Print);
            //Console.WriteLine(arr.All(IsEven));
            //arr.Average();


            //Action<IWorker> action = PrintSalary;

            //Func<int[], int> func = MaxElem;



            //List<Student> students = new List<Student>
            //{
            //    new Student
            //    {
            //        LastName = "Orlov",
            //        FirstName = "Kirill",
            //        BirthDay = new DateTime(2000, 5, 10),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AB",
            //            Number = 123456
            //        }
            //    },

            //    new Student
            //    {
            //        LastName = "Petroff",
            //        FirstName = "Oleg",
            //        BirthDay = new DateTime(1999, 4, 20),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AB",
            //            Number = 123455
            //        }
            //    },

            //    new Student
            //    {
            //        LastName = "Fedorova",
            //        FirstName = "Maria",
            //        BirthDay = new DateTime(2001, 10, 12),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AC",
            //            Number = 123456
            //        }
            //    },

            //    new Student
            //    {
            //        LastName = "Avdeeva",
            //        FirstName = "Olga",
            //        BirthDay = new DateTime(2001, 5, 5),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AA",
            //            Number = 123456
            //        }
            //    }
            //};

            //Console.WriteLine(students.Average(AvgDate));

            //Console.WriteLine(students.Count(BirthMay));

            //var gr = students.GroupBy(FromMonth);
            //foreach ( var group in gr)
            //{
            //    Console.WriteLine("Month : " + group.Key);
            //    foreach (var st in group)
            //    {
            //        Console.WriteLine(st);
            //    }
            //}


            //Console.WriteLine(students.Find(BirthMay));
            //List<Student> may = students.FindAll(BirthMay);
            //may.ForEach(PrintStudent);

            //students.Sort((s1, s2) => s1.BirthDay.CompareTo(s2.BirthDay));

            //students.ForEach(s => Console.WriteLine(s));

            //var a = F(3, 5);



            /// 13.02.2025 ///
            /// /////////////
            /// 


            //Hashtable group = new Hashtable
            //{
            //    {
            //        new Student
            //        {
            //            LastName = "Orlov",
            //            FirstName = "Kirill",
            //            BirthDay = new DateTime(2000, 5, 10),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AB",
            //                Number = 123456
            //            }
            //        }, new ArrayList{8,9,7,10 }
            //    },
            //    {
            //        new Student
            //        {
            //            LastName = "Petroff",
            //            FirstName = "Oleg",
            //            BirthDay = new DateTime(1999, 4, 20),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AB",
            //                Number = 123455
            //            }
            //        }, new ArrayList{12,11,10,9, 10}
            //    },
            //    {
            //        new Student
            //        {
            //            LastName = "Fedorova",
            //            FirstName = "Maria",
            //            BirthDay = new DateTime(2001, 10, 12),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AC",
            //                Number = 123456
            //            }
            //        }, new ArrayList{8,7,9}
            //    },
            //    {
            //        new Student
            //        {
            //            LastName = "Avdeeva",
            //            FirstName = "Olga",
            //            BirthDay = new DateTime(2001, 5, 5),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AA",
            //                Number = 123456
            //            }
            //        }, new ArrayList{12,11,10,9, }
            //    }
            //};

            //PrintGroup(group);
            // Last First - 10, 12, 9
            // Last First - 10, 12, 9
            // Last First - 10, 12, 9, 10
            // Last First - 10, 12, 9
            //AddMark(group, lastName, firstName, mark);
            //PrintGroup(group);


            //Student st1 = new Student
            //{
            //    LastName = "Orlov",
            //    FirstName = "Kirill",
            //    BirthDay = new DateTime(2000, 5, 10),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AB",
            //        Number = 123456
            //    }
            //};

            //Student st2 = new Student
            //{
            //    LastName = "Orlewrertv",
            //    FirstName = "Kirisgsrgll",
            //    BirthDay = new DateTime(2010, 5, 10),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "ABer",
            //        Number = 12345634
            //    }
            //};

            //Console.WriteLine(st1.GetHashCode());
            //Console.WriteLine(st2.GetHashCode());


            //Calc calc = new Calc();
            //string expression = Console.ReadLine(); // 3 + 2
            //string[] num = expression.Split(' ');
            //CalcDelegate cd = null;
            //switch (num[1])
            //{
            //    case "+": cd = calc.Sum; break;
            //    case "-": cd = new CalcDelegate(calc.Diff); break;
            //    case "*": cd = Calc.Mult; break;
            //    case "/": cd = calc.Div; break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(cd(int.Parse(num[0]), int.Parse(num[2])));


            //VoidDelegate vd1 = Test;
            //Action a = Test;
            //Action<int> a1;
            ////vd1();
            //vd1 += Test2;
            //VoidDelegate vd2 = Test2;
            //vd2();

            //var v = vd1.GetInvocationList();
            //((VoidDelegate)v[1])();


            //foreach (VoidDelegate item in vd1.GetInvocationList())
            //{
            //    if (item == Test)
            //        item();
            //}

            /// 08.02.2025 ///
            /// /////////////
            /// 

            //Student st1 = new Student
            //{
            //    LastName = "Orlov",
            //    FirstName = "Kirill",
            //    BirthDay = new DateTime(2000, 5, 10),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AB",
            //        Number = 123456
            //    }
            //};

            //Student st2 = (Student)st1.Clone();


            //Console.WriteLine(st1);
            //Console.WriteLine(st2);

            //st2.FirstName = "lkjf wejfweof";
            //st2.StudentCard.Series = "XX";

            //Console.WriteLine(st1);
            //Console.WriteLine(st2);




            //Group group = new Group();  
            //foreach (Student st in group)
            //{
            //    Console.WriteLine(st);
            //}

            ////group.Sort();
            ////group.Sort(new DateComparer());
            ////group.Sort(Student.FromBirthDay);

            ////group.Sort(new StudentCardComparer());
            //group.Sort(Student.FromStudentCard);

            //Console.WriteLine();

            //foreach (Student st in group)
            //{
            //    Console.WriteLine(st);
            //}

            //Test test = new Test();
            //test.Show();

            //((IA)test).Show();

            //IA ia = new Test();
            //ia.Show();

            //IB ib = new Test();
            //ib.Show();

            //IC ic = new Test();
            //ic.Show();



            /// 06.02.2025 ///
            /// /////////////
            /// 




            // -, +, ++ , -- 
            // +, -, *, /, % 

            // 


            // = , . , ?: , sizeof(), typeof(), as , is, 
            // +=, ...... %= , &&, ||


            //Point p = new Point() { X = 4, Y = -6 };
            //Console.WriteLine(p);
            //Point p2 = +p;
            //Console.WriteLine(p2);
            //++p;
            //p++;
            //Console.WriteLine(p);

            //Point p3 = p + p2;
            //Console.WriteLine(p3);

            //p2 += p;

            //p3 = p2 + 10;
            //p3 += 10;
            //p3 = 10 + p;

            //if(p2 == p3)
            //{

            //}

            //if(p3 == 10)
            //{

            //}

            //if (10 == p3)
            //{

            //}


            //if(p && p2)
            //{

            //}

            //float f = (float)p;
            //Console.WriteLine(f);
            //Console.WriteLine(p["X"]);

            /// 01.02.2025 ///
            /// /////////////
            /// 


            //Human human = new Employee("Vasya", 20, 2000);
            //Console.WriteLine(human);

            //IWorker dir = new Director("Director", 30, 5000, 10);
            //IWorker economist = new Economist("Economist", 25, 3000, 3) { Salary = 5000 };
            //Employee cleaning = new CleaningManager("CleaningManager", 50, 1000, 100);

            //PrintSalary(new Stud(45));

            //IWorker[] employees = {dir, economist};
            //Employee[] employees = {dir, economist, cleaning};

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);

            //    //try
            //    //{
            //    //    ((Director)item).Info();
            //    //}
            //    //catch (Exception)
            //    //{

            //    //}


            //    //Economist ec = item as Economist;
            //    //if (ec != null)
            //    //{
            //    //    ec.Info();
            //    //}


            //    //if (item is CleaningManager)
            //    //{
            //    //    (item! as CleaningManager).Info();
            //    //}


            //}



            /// 30.01.2025 ///
            /// /////////////
            /// 


            //Stud student = new Stud(55);
            //student.Age = 20;

            //Stud st = new Stud(10) { Age = 20, MyProperty = 30 };


            //City city = new City() { Id = 12, Name = "Mykolaiv", District = new string[] { "Tcentralny", "Ingulskiy" } };
            //Console.WriteLine(city[1]);
            //Console.WriteLine(city["name"]);
            //Console.WriteLine(city["id"]);
            //Console.WriteLine(city["age"]);

            //First first = new First(2);


            //Human human = new Human("Vasya", 20);
            //human.Info();

            //Employee employee = new Employee("Jonh", 25, 5000);
            //employee.Info();





            /// 25.01.2025 ///
            /// /////////////
            /// 

            //int a = 9;
            //int[] arr = { 5, 6, 7, 8 };

            //Test(ref a, ref arr, out int b);

            //Console.WriteLine(b);

            //Console.WriteLine(a);
            //foreach (int i in arr)
            //    Console.Write(i + " ");
            //Console.WriteLine();


            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out int res));
            //Console.WriteLine(res);


            //First first = new First(22);
            //first.Print();


            //Stud student;
            //student = new Stud(55);
            //Console.WriteLine(student.GetID());
            //int s = student.GetID();

            //student.mark[0] = 100;
            //student.mark = new int[5];

            //student.Print();

            //Stud student2 = student;
            //student2.group = "P44";

            //student.Print();

            //Console.WriteLine(Stud.GetCourse());

            //Console.WriteLine(Stud.maxRate);



            //Point point = new Point();
            ////point.X = 10;
            ////point.Y = 10;
            //point.Print();

            //Index index = new Index();


            //Direction dir = Direction.Left;

            //Console.WriteLine(dir);

            //switch (dir)
            //{
            //    case Direction.Left:
            //        break;
            //    case Direction.Right:
            //        break;
            //    case Direction.Top:
            //        break;
            //    case Direction.Bottom:
            //        break;
            //    default:
            //        break;
            //}

            //string[] names = Enum.GetNames(typeof(Direction));
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //ThreadState t = ThreadState.Stopped | ThreadState.Background;
            //if ((t & ThreadState.Stopped) == ThreadState.Stopped)
            //{

            //}

            /// 23.01.2025 ///
            /// /////////////


            //int[] arr1 = new int[5] { 3, 6, 4, 6, 9 };
            //int[] arr2 = { 3, 6, 4, 6, 9 };
            //int[] arr3;
            //arr3 = new int[] { 3, 6, 4, 6, 9 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    //arr1[i] *= 2;
            //    Console.Write($"{arr1[i]} ");
            //}
            //Console.WriteLine();

            //foreach (int i in arr1)
            //{
            //    //i *= 2;
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(arr1.Count(a => a > 4));

            //Console.WriteLine(arr1.Sum());

            //Array.Sort(arr1);
            //foreach (int i in arr1)
            //{
            //    //i *= 2;
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //int[,] arr5 = new int[2, 3] { { 3, 5, 7 }, { 4, 2, 1 } };
            //Console.WriteLine(arr5[1,2]);
            //for (int i = 0; i < arr5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr5.GetLength(1); j++)
            //    {
            //        Console.Write(arr5[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[][] arr6 = new int[2][];
            //arr6[0] = new int[3] { 6,7,8};
            //arr6[1] = new int[4] { 1,2,3,4};

            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    foreach(int a in arr6[i])
            //    {
            //        Console.Write(a + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("size = ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];  
            //Random random = new Random();
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = random.Next(0, 10);
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(arr.Count(a => a % 2 == 0));
            //Console.WriteLine(arr.Count(a => a % 2 == 1));
            //Console.WriteLine(arr.Distinct().Count());


            //Console.Write("size1 = ");
            //int size1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("size2 = ");
            //int size2 = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[size1];
            //Random random = new Random();
            //for (int i = 0; i < size1; i++)
            //{
            //    arr1[i] = random.Next(0, 10);
            //    Console.Write(arr1[i] + " ");
            //}
            //Console.WriteLine();

            //int[] arr2 = new int[size2];
            //for (int i = 0; i < size2; i++)
            //{
            //    arr2[i] = random.Next(0, 10);
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();

            //int[] arr3 = arr1.Intersect(arr2).ToArray();
            //foreach (int i in arr3)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            //string st = "mama";
            //st += "papa";

            //StringBuilder sb = new StringBuilder();



            //Int32 a1 = 5;
            //int a = 5;

            //float a2 = 2.22f;

            //DateTime a3 = DateTime.Now;
            //Console.WriteLine(a3.DayOfYear);
            //Console.WriteLine(a3.ToLongDateString());
            //Console.WriteLine(a3.ToShortDateString());

            //Console.WriteLine($"{a2} info {a3.ToLongDateString()}");

            //int c = Convert.ToInt32(Console.ReadLine()); 
            //int d = Int32.Parse(Console.ReadLine()!);

            //DateTime d2 = Convert.ToDateTime(Console.ReadLine()!);
            //Console.WriteLine(d2);

            //int? s = null;
            //string? v = null;

            //if(a != 0)
            //{
            //    Console.WriteLine("True");
            //}

            //int m = a > 0 ? 1 : 0;

            //switch (m)
            //{
            //    case 0:
            //        Console.WriteLine();
            //        break;
            //    case 1:
            //    case 2:
            //        Console.WriteLine(3);
            //        break;
            //    default:
            //        break;
            //}

            //for (int i = 0; i < 3; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do {


            //}while(true);

            Console.ReadLine();
        }

        private static void informToTelegram(string message)
        {
            Console.WriteLine($"Отримано повідомлення в Телеграм: {message}");
        }

        private static void informToEmail(string message)
        {
            Console.WriteLine($"Отримано повідомлення в Email: {message}");
        }

        //private static void Teacher_ExamEvent(DateTime date)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
