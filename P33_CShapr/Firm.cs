using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{
    public enum FirmType
    {
        Marketing,
        IT,
        Finance,
        Government
    }

    public class Firm
    {
        public string? FirmName { get; set; }
        public DateTime? Established { get; set; }
        public FirmType? Type { get; set; }
        public string? Director { get; set; }
        public int? EmployeeCount { get; set; }
        public string? Address { get; set; }

        public Firm(string? firmName, DateTime? established, FirmType? type, string? director, int? employeeCount, string? address)
        {
            FirmName = firmName;
            Established = established;
            Type = type;
            Director = director;
            EmployeeCount = employeeCount;
            Address = address;
        }

        public void print()
        {
            Console.WriteLine("Firm Name: " + FirmName);
            Console.WriteLine("Established: " + Established);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Director: " + Director);
            Console.WriteLine("Employee Count: " + EmployeeCount);
            Console.WriteLine("Address: " + Address);
        }


        public static List<Firm> Firms = new List<Firm>
        {
            new Firm("FoodTech",                 new DateTime(2015, 5, 20),  FirmType.Marketing, "John White", 150, "London, UK"),
            new Firm("IT Solutions",             new DateTime(2018, 3, 10),  FirmType.IT, "Alice Black", 250, "New York, USA"),
            new Firm("FinancePro",               new DateTime(2000, 7, 5),   FirmType.Finance, "Michael Smith", 500, "London, UK"),
            new Firm("Government Services",      new DateTime(2010, 1, 15),  FirmType.Government, "William Brown", 800, "Washington, USA"),
            new Firm("FoodWorld",                new DateTime(2021, 11, 30), FirmType.Marketing, "Emma Johnson", 50, "Berlin, Germany"),
            new Firm("Tech Innovators",          new DateTime(2019, 9, 12),  FirmType.IT, "Sophia White", 180, "San Francisco, USA"),
            new Firm("Mega Finance",             new DateTime(2016, 2, 28),  FirmType.Finance, "David Black", 320, "London, UK"),
            new Firm("White & Black Consulting", new DateTime(2005, 6, 14),  FirmType.Marketing, "Edward Black", 120, "Manchester, UK"),
            new Firm("EcoFood Ltd",              new DateTime(2013, 8, 22),  FirmType.Marketing, "James Wilson", 90, "Paris, France")
        };
    };



}
