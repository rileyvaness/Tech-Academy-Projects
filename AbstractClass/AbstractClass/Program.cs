using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //#5 call the sayName method on the object.
            //So, I am grabbing the info from the employee class 
            //and telling the computer to execute it now:
            employee.sayName(employee.FirstName, employee.LastName);
            //#3 in interface: Use polymorphism to create an object of type
            //IQuittable and call the Quit() method on it. 
            employee.Quit();

        }

    }
}