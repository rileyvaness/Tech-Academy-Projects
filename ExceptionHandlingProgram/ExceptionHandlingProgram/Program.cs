using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begin #5: Now put the loop in a try/catch block.
            try
            {
                //Begin #1: Create a list of integers. 
                //Ask the user for a number to divide each number in the list by. 
                //Write a loop that takes each integer in the list, divides it by the number the user entered, 
                //and displays the result to the screen
                List<int> Numbers = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };
                Console.WriteLine("Please choose a number. We will divide it by each number in the index and print it out to you: ");
                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int Num in Numbers)
                {
                    int quotient = Num / input;
                    Console.WriteLine(quotient);
                    Console.ReadLine();
                }
                //End #1
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You may not divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program sucessfully executed");
                Console.ReadLine();
            }
            //End #5
        }

    }
}
