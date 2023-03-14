using System;
namespace HelloWorldDemo
{
	public class EvenOrOdd
	{
		public static void EvenOrOddNumbers()
		{
			Console.WriteLine("Enter the number");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number%2==0)
			{
				Console.WriteLine("{0} is even number",number);
			}
			else
			{
                Console.WriteLine("{0} is odd number",number);
            }
		}
		public static void TwoIntegerEqual()
		{
			Console.WriteLine("Enter two numbers");
			int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

			if (first == second)
			{
				Console.WriteLine("Enter two numbers are equal");
			}
			else
			{
                Console.WriteLine("Enter two numbers are not equal");
            }
        }
	}
}

