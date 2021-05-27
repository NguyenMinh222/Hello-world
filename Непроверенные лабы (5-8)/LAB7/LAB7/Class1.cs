using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    class MyMath
    {
        public static int CommonDivisor(int number1, int number2)
        {
            if (number2 != 0)
            {
                return CommonDivisor(number2, number1 % number2);
            }
            else
            {
                return number1;
            }
        }
        public static int CommonMultiple(int number1, int number2)
        {
            return number1 / CommonDivisor(number1, number2) * number2;
        }
    }
}