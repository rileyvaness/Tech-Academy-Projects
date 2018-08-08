using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods__part3
{
    class Math
    {
        public static int Addition (int number)

         {

            int newNumber = number + 9;
            return newNumber;
         }



        public static decimal NewAddition(decimal number2)


        {

            decimal newNumber = number2 + 3;
            return newNumber;

        }



        public static int String(string myString)

        {

            bool toInt = int.TryParse(myString, out int convertedString);
            int newConvertedString = convertedString + 25;
            return newConvertedString;

        }

    }

}