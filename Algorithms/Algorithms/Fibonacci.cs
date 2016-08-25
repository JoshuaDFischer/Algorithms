using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibonacci
    {

        public int Recursion(int counter)
        {
            if (counter <= 2)
                return 1;
            else
                return (Recursion(counter - 1) + Recursion(counter - 2));
        }

        public int DynamicPrograming(int counter)
        {
            int[] f = new int[counter + 2];
            f[0] = 0;
            f[1] = 1;

            if (counter == 0)
                return f[0];

            if (counter == 1)
                return f[1];

            if (f[counter] == 0)
                f[counter] = DynamicPrograming(counter - 1) + DynamicPrograming(counter - 2);
            else
                return f[counter];

            return f[counter];//	only used the last time in the recursion	
        }
    }
}
