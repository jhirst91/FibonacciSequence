using System;

namespace FibonacciSequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Format("Fibonacci sequence to {0}", num));
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
