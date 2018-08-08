using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please provide a number to use in some calculations by this program: ");
            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                //passing the userNumber through provided information 
                //from the math class and printing it to the screen. 
                Console.WriteLine(Math.Addition(userNumber));
                Console.WriteLine(Math.Division(userNumber));
                Console.WriteLine(Math.Multipication(userNumber));
            }
            //error message in case some one does not write a number.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
