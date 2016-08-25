using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibonacci
    {
        private int[] sequenceFromDynamic;
        
        //if you dont use this constructor then the dynamic method will not work because the array is not initialized
        public Fibonacci(int input)
        {
            sequenceFromDynamic = new int[input + 1];

            //used for storing all the values in the results of the fib seq
            //I set the first two numbers because they will allways be the same.
            sequenceFromDynamic[0] = 0;
            sequenceFromDynamic[1] = 1;
        }
        

        public int[] SequenceFromDynamic
        {
            get { return sequenceFromDynamic; }
        }

        public int Recursion(int counter)
        {
            if (counter <= 2)
                return 1;
            else
                return (Recursion(counter - 1) + Recursion(counter - 2));
        }

        public int DynamicPrograming(int counter)
            //this takes up more space because it is storing all the values of the seq in an array
        {

            if (counter == 0)
                return sequenceFromDynamic[0];

            if (counter == 1)
                return sequenceFromDynamic[1];

            if (sequenceFromDynamic[counter] == 0)
                sequenceFromDynamic[counter] = DynamicPrograming(counter - 1) + DynamicPrograming(counter - 2);
            else
                return sequenceFromDynamic[counter];
            
            return sequenceFromDynamic[counter];
        }
    }
}
