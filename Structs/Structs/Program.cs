using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //#1: Create a struct called number and give it the property "Amount"
    //and have it be of decimal data type.
    struct Number
    {
        public decimal Amount;
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            //#2 Here I create an object of the data type number and
            //assign a value to it.
            Number value = new Number()
            { Amount = 87.234212443m };
            //#3 Print the amount to the console. 
            Console.WriteLine("The value is: {0}", value.Amount);
            Console.ReadLine();
        }
    }
}
