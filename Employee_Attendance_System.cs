// guys, ni code for our project
// apa2 roger dlm Whatsapp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GROUP_PROJECT
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string EmployeeName = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(EmployeeName))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                EmployeeName = Console.ReadLine() ?? string.Empty;
            }
            Console.WriteLine("Please enter your ID: ");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Department: ");
            string EmployeeDept = Console.ReadLine() ?? string.Empty;

            //Create object of the Employee class
            Employee emp = new Employee(EmployeeName, EmployeeID, EmployeeDept);
            emp.DisplayEmployee();

        }

        class Employee
        {
            public string EmpName;
            public int EmpId;
            public string EmpDept;
            
            public Employee(string empName, int empId, string empDept)
            {
                EmpName = empName;
                EmpId = empId;
                EmpDept = empDept;
            }

            public void DisplayEmployee()  //Method to display employee details
            {
                Console.WriteLine($"Employee Name: {EmpName}");
                Console.WriteLine($"Employee ID: {EmpId}");
                Console.WriteLine($"Employee Department: {EmpDept}");
            }
        }
    }
}

