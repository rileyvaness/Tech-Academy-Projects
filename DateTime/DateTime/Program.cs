using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CurrentTime
{
    class Program
    {
        static void Main(string []args)
        {
            //#1 Print the current Date and time to the console.
            DateTime now = DateTime.Now;
        
            Console.WriteLine(now);
            
            //#2 Ask the user for a number.
            Console.WriteLine("Please type a whole number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            //#3 Caculate the time it will be by converting the users input to hours and adding it on to the current time.


            DateTime Then = DateTime.Now.AddHours(number);
          
            Console.WriteLine("In " + number + " hours it will be..." + Then);
            Console.ReadLine();
        }

    }
}
