using System;

namespace StructureEmployeeTest
{
    class Program
    {
        struct Employee
        {
            public int empID;
            public string empName;

            public Employee(int empID1, string empName1)
            {
                empID = empID1;
                empName = empName1;
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(empID1: 1, empName1: "Tom");
            Employee employee1 = new Employee(empID1: 2, empName1: "John");
            Console.WriteLine("--Employee--");
            Console.WriteLine("ID: " + employee.empID);
            Console.WriteLine("Name: " + employee.empName);
            Console.WriteLine("ID: " + employee1.empID);
            Console.WriteLine("Name: " + employee1.empName);

        }
        
    }
}
