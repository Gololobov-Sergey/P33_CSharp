using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class CoderAttribute : Attribute
    {
        string coder = "Gololobov SA";
        DateTime date = DateTime.Now;


        public CoderAttribute()
        {
            
        }

        public CoderAttribute(string coder, string date)
        {
            this.coder = coder;
            this.date = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            return $"Coder: {coder}, Date: {date.ToShortDateString()}";
        }
    }
}
