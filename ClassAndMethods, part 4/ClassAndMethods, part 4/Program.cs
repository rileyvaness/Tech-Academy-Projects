using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods__part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and press enter:  ");
            string number1 = Console.ReadLine();
    
            Console.WriteLine("Please enter a second number.Note: you do not have to enter a second number. Press enter to see the your number(s) used in Math:");
            string number2 = Console.ReadLine();
      
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);

            int num1;
            int num2;
            //this is the number I gave for the second input, 
            //if the user doesn't do this.
            int num3 = 800;

            bool one = int.TryParse(number1, out num1);
            bool two = int.TryParse(number2, out num2);

            //I use this to bring about a null statement, which 
            //will redirect the code if the second input is left blank.
            bool? three = null;
            
            if  (one && two == true)
            {
                int answer = MathProblem.Problem(num1,num2);
                Console.WriteLine("The answer: {0}", answer);
                Console.ReadLine();
            }
            else if (three ?? true)

        
            {
                int answer2 = MathProblem.Problem2(num1, num3);
                Console.WriteLine("The number I chose for you was " + num3);
                Console.WriteLine("The answer: {0}", answer2);
                Console.ReadLine();
            }
            
        }
    
    }
}
