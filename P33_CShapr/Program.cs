using System.Drawing;
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
       
        static void Main(string[] args)
        {
            Console.Title = "P33 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();


            Console.WriteLine("Слава Україні!");

            /// 08.02.2025 ///
            /// /////////////
            /// 

            Student st1 = new Student
            {
                LastName = "Orlov",
                FirstName = "Kirill",
                BirthDay = new DateTime(2000, 5, 10),
                StudentCard = new StudentCard
                {
                    Series = "AB",
                    Number = 123456
                }
            };

            Student st2 = (Student)st1.Clone();


            Console.WriteLine(st1);
            Console.WriteLine(st2);

            st2.FirstName = "lkjf wejfweof";
            st2.StudentCard.Series = "XX";

            Console.WriteLine(st1);
            Console.WriteLine(st2);

            


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
    }
}
