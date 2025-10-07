using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshOOPPractice._19Linq
{
    public class Employee()
    {
        public int EmpID { get; set; }
        public string EmpName {  get; set; }
        public string EmpDesg {  get; set; }
        public long EmpSalary { get; set; }
        public string EmpAdd {  get; set; }
    }
    public class linq1
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { EmpID = 1, EmpName = "Rahul Gautam", EmpDesg = "Manager", EmpSalary = 50000, EmpAdd = "Guwahati" },
            new Employee { EmpID = 2, EmpName = "Nitumani Das", EmpDesg = "Software Engineer", EmpSalary = 42000, EmpAdd = "Jorhat" },
            new Employee { EmpID = 3, EmpName = "Amit Sharma", EmpDesg = "HR Executive", EmpSalary = 35000, EmpAdd = "Tezpur" },
            new Employee { EmpID = 4, EmpName = "Priya Roy", EmpDesg = "Team Lead", EmpSalary = 60000, EmpAdd = "Dibrugarh" },
            new Employee { EmpID = 5, EmpName = "Rupam Bora", EmpDesg = "Intern", EmpSalary = 15000, EmpAdd = "Silchar" },
            new Employee { EmpID = 6, EmpName = "Sneha Choudhury", EmpDesg = "Project Coordinator", EmpSalary = 48000, EmpAdd = "Tinsukia" },
            new Employee { EmpID = 7, EmpName = "Arjun Nath", EmpDesg = "Senior Developer", EmpSalary = 55000, EmpAdd = "Nagaon" },
            new Employee { EmpID = 8, EmpName = "Puja Kalita", EmpDesg = "QA Engineer", EmpSalary = 38000, EmpAdd = "Jorhat" },
            new Employee { EmpID = 9, EmpName = "Rajdeep Gogoi", EmpDesg = "DevOps Engineer", EmpSalary = 53000, EmpAdd = "Dhemaji" },
            new Employee { EmpID = 10, EmpName = "Ankita Saikia", EmpDesg = "UI/UX Designer", EmpSalary = 40000, EmpAdd = "Guwahati" }
            };

            //First Or Default
            Console.WriteLine("Employee Details of ID 5:\n");
            var emp = employees.FirstOrDefault(x => x.EmpID == 5);
            Console.WriteLine($"{emp.EmpID}\n{emp.EmpName}\n{emp.EmpDesg}\n{emp.EmpSalary}\n{emp.EmpAdd}");

            //****** Filtering - Where  : Returns all employees whose condition will match
            Console.WriteLine($"\n---------------\nWhere Salary is > 50k\n");
            var emps = employees.Where(x => x.EmpSalary > 50000);
            foreach(var TempEmp in emps)
            {
                Console.WriteLine($"{TempEmp.EmpID}\n{TempEmp.EmpName}\n{TempEmp.EmpDesg}\n{TempEmp.EmpSalary}\n{TempEmp.EmpAdd}\n");
            }

            Console.WriteLine($"\n---------------\nWhere Salary is > 30k && Location : Guwahati\n");
            var emps2 = employees.Where(x => x.EmpSalary > 30000 && x.EmpAdd=="Guwahati");
            foreach (var TempEmp in emps2)
            {
                Console.WriteLine($"{TempEmp.EmpID}\n{TempEmp.EmpName}\n{TempEmp.EmpDesg}\n{TempEmp.EmpSalary}\n{TempEmp.EmpAdd}\n");
            }

            //****** Projection - Select  :  Extracts only the employee names/Location/Designation from each object.
            Console.WriteLine($"\n---------------\nSelect all Location/Salary/Designation\n");
            //IEnumerable<string> emps3 = employees.Select(x=>x.EmpAdd);   //it returns IEnumerable<T> or we can store in "var"
            List<string> emps3 = employees.Select(x => x.EmpAdd).ToList();
            foreach (var TempEmp in emps3)
            {
                Console.WriteLine($"{TempEmp}\n");
            }

            //****** Ordering — OrderBy(), OrderByDescending(), ThenBy()  :  Sorts employees by salary ascending, descending, or by multiple criteria.
            Console.WriteLine($"\n---------------\nSort Employess using Ascending/Descending/Other Criteria\n");
            //var emps4 = employees.OrderBy(x => x.EmpSalary);
            //var emps4 = employees.OrderByDescending(x => x.EmpSalary);
            var emps4 = employees.OrderByDescending(x => x.EmpSalary).ThenBy(x=>x.EmpAdd);

            foreach (var TempEmp in emps4)
            {
                Console.WriteLine($"{TempEmp.EmpID}\n{TempEmp.EmpName}\n{TempEmp.EmpDesg}\n{TempEmp.EmpSalary}\n{TempEmp.EmpAdd}\n");
            }

            //var emps5 = employees.OrderByDescending(x => x.EmpSalary);
            //Console.WriteLine($"{emps5.EmpID}\n{emps5.EmpName}\n{emps5.EmpDesg}\n{emps5.EmpSalary}\n{emps5.EmpAdd}");

            //****** Element Operator - First(), FirstorDefault()
            Console.WriteLine($"\n---------------\n Element Operator - First(), FirstorDefault()\n");
            //var emps5 = employees.First();  //It will Return the First obj form the List
            var emps5 = employees.FirstOrDefault(x => x.EmpAdd == "Nagaon"); //It iterates through the collection, As soon as it finds an employee where EmpAdd == "Guwahati", it stops and returns that object.
            emp = emps5;
            emp = employees.ElementAt(3);  //Returns the element at the given index (0-based index)
            Console.WriteLine($"{emp.EmpID}\n{emp.EmpName}\n{emp.EmpDesg}\n{emp.EmpSalary}\n{emp.EmpAdd}");

        }


    }
}
