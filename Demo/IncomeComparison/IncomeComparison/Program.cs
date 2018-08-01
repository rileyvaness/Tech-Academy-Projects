using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
           
            //Data on Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourly1 = Console.ReadLine();
            int hourly1Int = Convert.ToInt32(hourly1);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked = Console.ReadLine();
            int hoursWorkedInt = Convert.ToInt32(hoursWorked);

            //Data on Person 2 
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourly2 = Console.ReadLine();
            int hourly2Int = Convert.ToInt32(hourly2);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int hoursWorked2Int = Convert.ToInt32(hoursWorked2);
            
            //Annual Salaries of Person 1 and 2
            Console.WriteLine("Annual Salary of Person 1: ");
            int combined = hourly1Int + hoursWorkedInt;
            Console.WriteLine(combined * 52);
            Console.WriteLine("Annual Salary of Person 2: ");
            int combined2 = hourly2Int + hoursWorked2Int;
            Console.WriteLine(combined2 * 52);
           
            //Does Person 1 make more?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = combined > combined2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
            

        }
    }
}
