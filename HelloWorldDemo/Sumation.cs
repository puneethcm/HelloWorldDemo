using System;
namespace HelloWorldDemo
{
	public class Sumation
	{
        public static void summation(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i * i);
                Console.WriteLine("sumation {0} : {1}",i,sum);
            }
        }
    }
}

