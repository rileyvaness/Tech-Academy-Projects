using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndConstVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1: Create a const variable
            const string shakespeareShow = "Antony and Cleopatra";
            Console.WriteLine("We are currently performing, {0}, this weekend. ", shakespeareShow);
            
            
            //#2 Create a variable using "var"
            var TheaterTroupe = "Prague Shakespeare Company";
            Console.WriteLine("The show will be performed by the {0}.", TheaterTroupe);
            //#3 Chain two constructors together

            Tickets tickets = new Tickets();
            {
                Console.WriteLine("There are still " + tickets.Show + " tickets left! Get your tickets now!");
               
            }

            Console.ReadLine();

        }




    }
}
