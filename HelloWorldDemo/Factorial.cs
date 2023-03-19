using System;
namespace HelloWorldDemo
{
	public class Factorial
	{
        public static void FindFactorial()
        {
            int i, fact = 1;
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of {0} : {1}",n, fact);
        }
    }
}

