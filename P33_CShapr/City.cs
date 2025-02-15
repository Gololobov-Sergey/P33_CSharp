using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] District { get; set; }

        public City(int id)
        {
            Id = id;
        }

        public string this[int index]
        {
            get { return District[index]; }
            set { District[index] = value; }
        }

        public string this[string index]
        {
            get 
            { 
                if(index == "name")
                    return Name;
                else if(index == "id")
                    return Id.ToString();
                return "None";
            }
            set { Name = value; }
        }
    }
}
