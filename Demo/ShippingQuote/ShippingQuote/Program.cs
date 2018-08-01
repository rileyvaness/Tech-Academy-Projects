using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below.");

            //package Weight. If greater then 50, can not ship. 
            Console.WriteLine("Package weight: ");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            

            //package width
            Console.WriteLine("Package width: ");
            string width = Console.ReadLine();
            int packageWidth = Convert.ToInt32(width);
            
            //package height
            Console.WriteLine("Package height: ");
            string height = Console.ReadLine();
            int packageHeight = Convert.ToInt32(height);
            
            //package length
            Console.WriteLine("Package length: ");
            string length = Console.ReadLine();
            int packageLength = Convert.ToInt32(length);

            //if total dimensions are greater then 50, can not ship.
            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package to big to be shipped via pacakge express.");
            }

            //Computing the quote
            Console.WriteLine("Your estimated total for shipping this product is: ");
            int total = packageWidth + packageHeight + packageLength;
            int product = total * packageWeight;
            int quotient = product / 100;
            int remainder = product % 100;
            Console.WriteLine("$" + quotient + "." + remainder);
            Console.WriteLine("Thank you! Have a nice Day!");
          

            Console.ReadLine();
        }
    }
}
