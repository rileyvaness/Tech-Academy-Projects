using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
        public int ID;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //#1 List of Employees. Two have the name of Joe. 

            List<Employee> employees = new List<Employee>()
            {
              new Employee  { FirstName = "Riley", LastName = "Smiley", ID = 1 },
           new Employee  { FirstName = "Jeff", LastName = "Smith", ID = 2},
           new Employee { FirstName = "Joe", LastName = "Walker", ID = 3 },
           new Employee { FirstName = "William", LastName = "Shakespeare", ID = 4},
            new Employee { FirstName = "Thomas", LastName = "Dekker", ID = 5},
            new Employee { FirstName = "Christoper", LastName = "Marlowe", ID = 6},
            new Employee { FirstName = "John", LastName = "Webster", ID = 7},
            new Employee { FirstName = "Ben", LastName = "Jonson", ID = 8},
            new Employee { FirstName = "Francis", LastName = "Beaumont", ID = 9},
            new Employee { FirstName = "Joe", LastName = "Smith", ID = 10}
            };

            //#2 Use a foreach loop. Create a new list of employees named joe.

            List<Employee> Joe = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joe.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }

            }
            Console.ReadLine();

            
            //#3 Use a lambda expression. Create new list of employees named joe. 

            List<Employee> lambdaJoe = new List<Employee>();
            lambdaJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach(Employee employee in lambdaJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();

            //#4 Use a lanmbda expression to see all employees with ID number greater
            //then 5. 

            List<Employee> fiveAndUp = new List<Employee>();
            fiveAndUp = employees.Where(x => x.ID > 5).ToList(); 

            foreach(Employee employee in fiveAndUp)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);

            }
            Console.ReadLine();

              
        }


    }
}
