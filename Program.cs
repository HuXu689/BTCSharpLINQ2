using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCSharpBTLINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Employee.getEmployees();
            List<Position> positions = Position.getPositions();
            List<Department> departments = Department.getDepartments();

            Console.WriteLine("Nhap tu khoa tim kiem:");
            string keyword = Console.ReadLine();

            Console.WriteLine("Nhap tuoi tu:");
            int minAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap den tuoi:");
            int maxAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vi tri:");
            string position = Console.ReadLine();

            Console.WriteLine("Nhap phong ban:");
            string department = Console.ReadLine();

            var searchResults = employees
                .Where(e => (e.Name.Contains(keyword) || e.Description.Contains(keyword)) ||
                            positions.Any(p => p.Name.Contains(keyword) && p.ID == e.PositionID) ||
                            departments.Any(d => d.Name.Contains(keyword) && d.ID == e.DepartmentID))
                .Where(e => e.Age >= minAge && e.Age <= maxAge)
                .Where(e => position == "" || positions.Any(p => p.Name.Contains(position) && p.ID == e.PositionID))
                .Where(e => department == "" || departments.Any(d => d.Name.Contains(department) && d.ID == e.DepartmentID))
                .ToList();

            if (searchResults.Count > 0)
            {
                Console.WriteLine("Ket qua tim kiem:");
                foreach (var employee in searchResults)
                {
                    Console.WriteLine($"ID: {employee.ID}");
                    Console.WriteLine($"Name: {employee.Name}");
                    Console.WriteLine($"Age: {employee.Age}");
                    Console.WriteLine($"Position: {positions.FirstOrDefault(p => p.ID == employee.PositionID)?.Name}");
                    Console.WriteLine($"Department: {departments.FirstOrDefault(d => d.ID == employee.DepartmentID)?.Name}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay ket qua phu hop.");
            }

            Console.ReadLine();
        }
    }
}
