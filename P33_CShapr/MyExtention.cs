using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    static class MyExtention
    {
        public static string GetBDFromString(this Student st)
        {
            return st.BirthDay.ToString();
        }

        //public static string PadCenter(this string str, int totalWidth)
        //{
        //    int len = totalWidth - str.Length;
        //    int len1 = len / 2;
        //    StringBuilder sb = new StringBuilder("");
        //    sb.Append(" ".Mult(len1));
        //    sb.Append(str);
        //    sb.Append(" ".Mult(totalWidth - str.Length - len1));
        //    return sb.ToString();
        //}

        //public static string Mult (this string str, int n)
        //{
        //    StringBuilder sb = new StringBuilder("");
        //    for (int i = 0; i < n; i++)
        //    {
        //        sb.Append(str);
        //    }
        //    return sb.ToString();
        //}


        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    count++;
                }
            }

            int[] newArr = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    newArr[count++] = array[i];
                }
            }
            return newArr;
        }
    }
}
