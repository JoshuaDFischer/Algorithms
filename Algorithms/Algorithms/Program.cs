//Author: Joshua D Fischer


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFibonacci();
           
            

           
        }

        static void RunFibonacci()
        {
            int inputFib = getFibStartNumber();
            Fibonacci fib = new Fibonacci(inputFib);

            //stop watch used to check time comparison for two differnt approaches
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int fibResult = fib.Recursion(inputFib);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Recusion Result: \t\t" + fibResult + "\tTime spent to perform in milliseconds:\t" + watch.Elapsed.TotalMilliseconds);

            watch.Reset();

            watch.Start();
            //this approach may be slower, but it gives you the ability to store all the numbers in the seq if you wanted to.
            int test = fib.DynamicPrograming(inputFib);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Dynamic Programming: \t\t" + test + "\tTime spent to perform in milliseconds:\t" + watch.Elapsed.TotalMilliseconds);
            var builder = new StringBuilder();
            Array.ForEach(fib.SequenceFromDynamic, x => builder.Append(x));
            var res = builder.ToString();

            Console.Write(fib.SequenceFromDynamic[4].ToString());
            Console.ReadKey();
        }

        static int getFibStartNumber()
        {
            Console.WriteLine("Fibonacci");
            Console.Write("Please enter a number under 30: ");

            int inputFib;
            //Only returns a responce from the user if it can be converted to int
            while (!Int32.TryParse(Console.ReadLine(), out inputFib))
            {
                Console.Write("Please enter a number under 30: ");
            }
            return inputFib;
        }
    }
}
