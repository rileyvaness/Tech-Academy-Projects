using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {FirstName = "George", LastName = "Washington", Id = 01 },
                new Employee {FirstName = "John", LastName = "Adams", Id = 02 }

            };

            //"==" operator will check if the two Employees have the same Id,
            //by comparing their Id property.
          
            bool equal = employees[0].Id == employees[1].Id;
            if (equal)
            {
                Console.WriteLine("They have the same Id");
            }
            else
            {
                Console.WriteLine("They have a different Id");
            }
            Console.ReadLine();
        }
    }
}
