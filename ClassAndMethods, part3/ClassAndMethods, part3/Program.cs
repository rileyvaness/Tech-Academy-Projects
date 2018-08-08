using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods__part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I pass in an integer for some basic addition
            //to be referenced from the math clas.
            Math operation = new Math();
            int number= 1;
            int result = Math.Addition(number);
            Console.WriteLine("The answer is: {0}", result);
            Console.ReadLine();
        

            //Here I pass in a decimal
            //to be refreneced from the math class.
            decimal number2 = 94.23m;
            decimal result2 = Math.NewAddition(number2);
            Console.WriteLine("The new answer is: {0}", result2);
            Console.ReadLine();


            //Here is a number, disguised as a string. 
            //In the math class, I convert the string to an Integer, 
            // thus allowing me to use preform the math I call for. 
            string number3 = "22";
            int result3 =  Math.String(number3);
            Console.WriteLine("The newest answer is: {0}", result3);
             Console.ReadLine();



        }
    }
}
