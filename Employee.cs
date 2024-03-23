using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCSharpBTLINQ2
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public double Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public static List<Employee> getEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID=1, Name="Nguyen Van Hoang", Description="Employee 1 Description", DepartmentID=1, PositionID=2, Salary=70000, BirthDate=new DateTime(1995, 4, 25) },
                new Employee { ID=2, Name="Tran Thi Mai", Description="Employee 2 Description", DepartmentID=2, PositionID=1, Salary=72000, BirthDate=new DateTime(1992, 8, 15) },
                new Employee { ID=3, Name="Pham Duc Anh", Description="Employee 3 Description", DepartmentID=1, PositionID=1, Salary=68000, BirthDate=new DateTime(1998, 12, 1) },
                new Employee { ID=4, Name="Le Thi Hong", Description="Employee 4 Description", DepartmentID=3, PositionID=3, Salary=71000, BirthDate=new DateTime(1994, 5, 19) },
                new Employee { ID=5, Name="Vu Đinh Long", Description="Employee 5 Description", DepartmentID=2, PositionID=3, Salary=65000, BirthDate=new DateTime(1990, 3, 22) }
            };
        }
    }
}
