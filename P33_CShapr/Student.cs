using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    class StudentCard : IComparable, ICloneable
    {
        public string? Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if(obj is StudentCard)
            {
                StudentCard sc  = (StudentCard)obj;
                return $"{Series}{Number.ToString()}".CompareTo($"{sc.Series}{sc.Number.ToString()}");
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    internal class Student : IComparable, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer FromBirthDay { get => new DateComparer(); }
        public static IComparer FromStudentCard { get => new StudentCardComparer(); }

        public int CompareTo(object? obj)
        {
            if (obj is Student)
            {
                Student st = (Student)obj;
                return $"{LastName} {FirstName}".CompareTo($"{st.LastName} {st.FirstName}");
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{LastName!.PadRight(15)} {FirstName!.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
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


    class DateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Student && y is Student)
            {
                return (x as Student)!.BirthDay.CompareTo((y as Student)!.BirthDay);
            }
            throw new NotImplementedException();
        }
    }


    class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student)!.StudentCard!.CompareTo((y as Student)!.StudentCard);
            }
            throw new NotImplementedException();
        }
    }
}
