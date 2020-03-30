using System;

namespace FibonacciSequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Up to which number should this Fibonacci sequence go to?");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(String.Format("Fibonacci sequence to {0} digits", num));
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Fibonacci(i));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
