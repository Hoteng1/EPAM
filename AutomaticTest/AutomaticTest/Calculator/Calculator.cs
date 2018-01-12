using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticTest.Calculator
{
    class Calculator
    {
        static public int Sum(int x,int y)
        {
            return x + y;
        }

        static public int Difference(int x, int y)
        {
            return x - y;
        }

        static public int Division(int x, int y)
        {
            return x / y;
        }

        static public int Multi(int x, int y)
        {
            return x * y;
        }
    }
}
