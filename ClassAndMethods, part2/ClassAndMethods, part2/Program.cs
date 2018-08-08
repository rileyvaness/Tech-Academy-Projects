using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods__part2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Math Addition = new Math();
            int number = 1;
            int result = Math.Add(number);
            Console.WriteLine("Answer = {0}. " , result);
            Console.ReadLine();
        }
    }
}
