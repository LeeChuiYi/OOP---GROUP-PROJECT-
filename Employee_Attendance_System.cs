<<<<<<< HEAD
// guys, code ni yg utk group project kita. x rasa boleh run dlm compiler 
// kt github sbb kene download extension, and extension boleh download and store dlm storage computer korg
//NOTE: 
//"When you install an extension, it is saved in the browser's local storage. 
// You can ensure your extensions are synced across VS Code instances, including 
// different browsers and even the desktop,"
// so kalau korg nk run code kene copy and paste dlm vs code korg msing2 ok?

// or korg ada idea cane nk run sbb so far i search x boleh nk run dlm compiler github ni


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
