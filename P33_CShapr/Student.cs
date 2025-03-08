using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P33_CShapr
{
    public class StudentCard : IComparable<StudentCard>, ICloneable
    {
        public string? Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StudentCard? sc)
        {
            return $"{Series}{Number.ToString()}".CompareTo($"{sc.Series}{sc.Number.ToString()}");
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    [Coder]
    
    public class Student : IComparable<Student>, ICloneable
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get => new DateComparer(); }
        public static IComparer<Student> FromStudentCard { get => new StudentCardComparer(); }


        [Coder("Chernichko V", "07.03.2025")]
        public int CompareTo(Student? st)
        {
            //if (obj is Student)
            //{
            //    Student st = (Student)obj;
            //    return $"{LastName} {FirstName}".CompareTo($"{st.LastName} {st.FirstName}");
            //}
            //throw new NotImplementedException();

            return $"{LastName} {FirstName}".CompareTo($"{st.LastName} {st.FirstName}");

        }

        [Coder("Gololobov SA", "05.03.2025")]
        public override string ToString()
        {
            try
            {
                return $"{LastName.PadRight(15)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = (StudentCard)this.StudentCard!.Clone();
            return temp;
        }

        public override int GetHashCode()
        {
            return $"{LastName}{FirstName}".GetHashCode();
        }

        // #1
        //public void Exam(DateTime date)
        //{
        //    Console.WriteLine($"Екзамен для {LastName + " " + FirstName} назначений на {date.ToShortDateString()}");
        //}

        //#2
        public void Exam(object sender, ExamEventArgs task)
        {
            Console.WriteLine($"Викладач {((Teacher)sender).FullName} назначив екзамен для {LastName + " " + FirstName}, " +
                $"по предмету {task.Subject}, який пройде {task.Date.ToShortDateString()} в аудиторії {task.Room}");
            
        }

        public void SaveToStream(StreamWriter stream)
        {
            if(stream != null)
            {
                stream.WriteLine(FirstName);
                stream.WriteLine(LastName);
                stream.WriteLine(BirthDay.ToShortDateString());
                stream.WriteLine(StudentCard.Series);
                stream.WriteLine(StudentCard.Number);
            }
        }
    }


    class Group : IEnumerable
    {
        Student[] students =
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

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }


    class DateComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.BirthDay.CompareTo(y!.BirthDay);
        }
    }


    class StudentCardComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.StudentCard!.CompareTo(y!.StudentCard);
        }
    }

    public delegate void ExamDelegate(DateTime date);

    public class Teacher
    {
        public string FullName { get; set; }

        // #1

        ////public event ExamDelegate ExamEvent;
        //public event Action<DateTime> ExamEvent;

        //public void SetExam(string date)
        //{
        //    if (ExamEvent != null)
        //    {
        //        ExamEvent(Convert.ToDateTime(date));
        //    }
        //}

        public EventHandler<ExamEventArgs> ExamEvent;

        public void SetExam(ExamEventArgs task)
        {
            if(ExamEvent != null)
            {
                ExamEvent(this, task);
            }
        }
    }


    public class ExamEventArgs : EventArgs
    {
        public int Room { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
    }

    //class MyStudent : Student
    //{
    //    public string GetBDFromString()
    //    {
    //        return BirthDay.ToString();
    //    }
    //}
}
