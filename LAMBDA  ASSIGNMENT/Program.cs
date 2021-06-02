using System;
using System.Collections.Generic;
using System.Linq;


namespace LAMBDA__ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is the employeeList");
            List<Employee> EmpList1 = new List<Employee>()
            {
                new Employee
                {
                    FirstName = "John", LastName = "smith", ID = 4
                },
                new Employee
                {
                    FirstName = "Joe", LastName = "alex", ID = 6
                },
                new Employee
                {
                    FirstName = "Joe", LastName = "smith", ID = 3
                },
                new Employee
                {
                    FirstName = "Bill", LastName = "Jerry", ID = 7
                }
            };
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee emp in EmpList1)
            {
                if (emp.FirstName == "Joe")
                {
                    JoeList.Add(emp);
                }
            }
            foreach (Employee employee in JoeList)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            
            List<Employee> employeeTrack2 = EmpList1.Where(x => x.FirstName == "Joe").ToList();
      
            List<Employee> employeeTrack3 = EmpList1.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in employeeTrack3)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            foreach (Employee employee in employeeTrack2)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            Console.ReadLine();


        

            


           
            
            
            
            
    }   }
}
