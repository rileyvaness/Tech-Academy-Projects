using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                //#4 sample student to check inheritance
                new Employee  {FirstName = "Sample", LastName = "Student", Id = 01},
                 
            };
            foreach(Employee employee in employees)
            {
                //#5 call the superclass method SayName ()
                employee.sayName();
                Console.WriteLine("Id: " + employee.Id);
                Console.ReadLine();
            }

        }
    }
}
