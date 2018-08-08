using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods__part_4
{

    //I put two Problems in the class MathProblem. The first 
    // is for if the user puts in two numbers. The second; if they
    //do not. 
    class MathProblem
    {
        public static int Problem(int num1, int num2)
        {
            int answer = (num1 * num2) -num1;
            return answer;

        }
        public static int Problem2(int num1, int num3 )
        {
            int answer2 = (num1 * num3) - num1;
            return answer2;

        }


    }
}