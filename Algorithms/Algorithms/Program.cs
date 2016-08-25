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
            Fibonacci fib = new Fibonacci();
            Console.WriteLine("Fibonacci");
            Console.Write("Please enter a start number: ");
            string ans = Console.Read().ToString();
            int inputFib = Convert.ToInt32(ans);
            Console.WriteLine("Fibonacci with input number: " + inputFib);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int fibResult = fib.Recursion(inputFib);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Recusion: " + fibResult + "\tTime spent to perform in milliseconds:" + watch.Elapsed.TotalMilliseconds);

            watch.Reset();

            watch.Start();
            int test = fib.DynamicPrograming(inputFib);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.Write("Dynamic Programming: " + test + "\tTime spent to perform in milliseconds:" + watch.Elapsed.TotalMilliseconds);

            Console.Read();
        }
    }
}
