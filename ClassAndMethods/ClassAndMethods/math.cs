using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Math
        //when Math is called in the program it consults this class.
    {
        public static int Addition(int userNumber)
        {
            return userNumber + 72;
        }
        public static int Division(int userNumber)
        {
            return userNumber / 2;
        }
        public static int Multipication(int userNumber)
        {
            return userNumber * 22;
        }
    }
}
