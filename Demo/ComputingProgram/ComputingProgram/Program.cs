using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". Nice to meet you. Lets do some computing!");
            Console.WriteLine("Press \"Enter\" to begin:");
            Console.ReadLine();
           

            //multiply by 50 
            Console.WriteLine("Pick a number, any number: ");
            string number1 = Console.ReadLine();
            int number1Int = Convert.ToInt32(number1);
            Console.WriteLine("We will now take " + number1 + " and multiply it by 50! Press \"Enter\" to see the result: ");
            Console.ReadLine();
            int num1 = number1Int;
            int num2 = 50;
            int product = num1 * num2;
            Console.WriteLine(product);


            //add by 25
            Console.WriteLine("Pretty cool, huh? Pick another number:");
            string number2 = Console.ReadLine();
            int number2Int = Convert.ToInt32(number2);
            Console.WriteLine("We will now take " + number2 + " and add 25 to it! Press \"Enter\" to see the result: ");
            Console.ReadLine();
            int num3 = number2Int;
            int num4 = 25;
            int total = num3 + num4;
            Console.WriteLine(total);


            //divide by 12.5
            Console.WriteLine("Wow, this is so fun! Let's pick another number: ");
            string number3 = Console.ReadLine(); 
            int number3Int = Convert.ToInt32(number3);
            Console.WriteLine("We will now take " + number3 + " and divide it by 12.5. Press \"Enter\" to see the result: ");
            Console.ReadLine();
            int num5 = number3Int;
            double num6 = 12.5;
            double quotient = num5 / num6;
            Console.WriteLine(quotient);


            //check if greater then 50 
            Console.WriteLine("Numbers are the best! Pick another: ");
            string number4 = Console.ReadLine();
            int number4Int = Convert.ToInt32(number4);
            Console.WriteLine("We will now see if " + number4 + " is greater then 50! Press \"Enter\" to find out: ");
            Console.ReadLine();
            int num7 = number4Int;
            int num8 = 50;
            bool trueOrFalse = num8 < num7;
            Console.Write(trueOrFalse.ToString());
            Console.WriteLine();
            


            //print out remainder after being divided by 7
            Console.WriteLine("One final number. Pick a good one: ");
            string number5 = Console.ReadLine();
            int number5Int = Convert.ToInt32(number5);
            Console.WriteLine("We will now divide " + number5 + " by 7 and print out the remainder. Press \"Enter\" to see the result: ");
            Console.ReadLine();
            int num9 = number5Int;
            int num10 = 7;
            int remainder = number5Int % num10;
            Console.WriteLine(remainder);
            Console.WriteLine("Thank you for supplying all of the numbers, " + name + ". I hope you enjoyed this program. ");
            Console.ReadLine();
            

   

            ;

        



        }
    }
}
