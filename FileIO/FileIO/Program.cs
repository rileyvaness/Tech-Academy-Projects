using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 Ask the user for a number
            Console.WriteLine("Hello. Please type in a whole number.");
            //#2 Log the number to a text file
            int number = Convert.ToInt32(Console.ReadLine());
            string userNumber = number.ToString();

            //#3 Print the text file back to the user
            Console.WriteLine(userNumber);
            using (StreamWriter file = new StreamWriter(@"C:\Users\riley\Documents\computing.txt", true))
            {
                file.WriteLine(userNumber);
            }
            Console.ReadLine();


        
        }
    }
}
