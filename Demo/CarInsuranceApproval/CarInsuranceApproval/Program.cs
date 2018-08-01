using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car insurance Approval Questions: ");

            //What is your age?
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int personsAge = Convert.ToInt32(age);
           //DUI?
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\" ");
            string hasDUI = Console.ReadLine();
           //Speeding Tickets?
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int speedingTicket = Convert.ToInt32(speeding);
            //Are you qualified?
            Console.WriteLine("Qualified?");
            bool isApproved = (personsAge >= 15 && hasDUI != "true" && speedingTicket <= 3);
            Console.WriteLine(isApproved);
            Console.ReadLine();




        }
    }
}
