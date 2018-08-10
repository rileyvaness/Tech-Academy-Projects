using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Week week = new Week();
            bool isDay = false;
            //#2 Prompt the user to enter current day of week.
            Console.WriteLine("What day is it today?");
            //#4 Statment is wrapped in a try/catch block. So, if user enters
            //something that is not a day, they will be given the message in the 
            //catch section. 
            while (!isDay)
            {
                string day = Console.ReadLine();
                try
                {
                    //#3 Assign value to a variable of that enum data type you just created.
                    //Basically this line is making sure that value that is entered
                    //matches up to a day in the Enum.
                    Week.Days dayChosen = (Week.Days)Enum.Parse(typeof(Week.Days), day);
                    Console.WriteLine("Thank you! Now I know that today is a {0}.", dayChosen);
                    isDay = true;
                    Console.ReadLine();
                }
                catch
                {

                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }
            }

          
        }
    }
}
