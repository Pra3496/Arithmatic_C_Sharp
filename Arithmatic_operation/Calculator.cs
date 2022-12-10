using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_operation
{
    internal class Calculator
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Substraction(int first, int second)
        {
            return first - second;
        }

        public int Multiplication(int first, int second)
        {
            return first * second;
        }

        public double division(int first, int second)
        {
            return ((float)first) / ((float)second);
        }

    }
}
