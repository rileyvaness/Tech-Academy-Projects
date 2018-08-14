using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
    
        static void Main(string[] args)
        {
         


            
           

            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                //#1: Ask the user for their age.
                Console.WriteLine("What is your age?");
                {
                    //#3 Exceptions handled using the try/catch
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                        if (age <= 0)
                        {
                            throw new ZeroNegative();
                        }
                        else
                        {
                            validAnswer = true;
                        }
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("I am sorry but this is not an integer. Please enter a whole number.");
                        continue;
                    }
                    //#4: Error message for 0 or negative
                    catch (ZeroNegative)
                    {
                        Console.WriteLine("Oops. Looks like you entered a 0 or a negative number. Please try again");
                        continue;
                    }
                    //#5 Error message for anything else.
                    catch(Exception)
                    {
                        Console.WriteLine("I am sorry. Something doesn't seem to be working right. Please try again.");
                    }

                }

            }
            //#2: Display the year the user was born.
            DateTime now = DateTime.Now;
            Console.WriteLine("You were born in the year {0}." , now.Year - age);
            Console.ReadLine();
            return;

        }

   

        
    }
}
