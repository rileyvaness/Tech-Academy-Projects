using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            //#3 Instatiate an employee object with type "string"
           


                Employee<string> employee = new Employee<string>()
                        
            {
                FirstName = "William",
                LastName = "Shakespeare",
            };

            
                employee.Things = new List<string>();
            
            employee.Things.Add("Romeo and Juliet");
            employee.Things.Add("MacBeth");
            employee.Things.Add("Merry Wives of Windsor");
            Console.ReadLine();

            //#4 Instantiate an employee object with type "int"
            Employee<int> employee2 = new Employee<int>()
            {
                FirstName = "Christopher",
                LastName = "Marlowe",
            };

            //#5 Here are some loops to gather and display
            //all the info from the two objects. 
        employee2.Things = new List<int>() {1590, 1593, 1604 };
        Console.WriteLine("Some popular plays written by  " + employee.FirstName +" "+ employee.LastName + ":");
        Console.WriteLine("\n");
        for (int i = 0; i < employee.Things.Count; i++)
            {
         
                Console.WriteLine( employee.Things[i]);
            }
        Console.WriteLine("\n");
        Console.WriteLine("The years that " + employee2.FirstName + " " + employee2.LastName + " wrote \"Tamburline\", \"Edward II\", and \"Doctor Faustus\" \n (note: list is in chronological order):");
           
        Console.WriteLine("\n");
        for (int j = 0; j < employee2.Things.Count; j++)
        {
            Console.WriteLine(employee2.Things[j]);
            }
            Console.ReadLine();
            
        }
       
    }

