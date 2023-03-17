using System;
namespace HelloWorldDemo
{
	public class PowerOfTwo
	{
		public static void PowerTwo()
		{
            int p = 2;
            Console.WriteLine("Enter the number");
			int number = Convert.ToInt32(Console.ReadLine());
			for(int i=0; i<= number; i++)
			{
				if (i == 0)
				{
					p = 1;
                    //Console.WriteLine(i);
                }
				else
				{
					p = 2 * i;
				}
				Console.WriteLine(p);
			}
		}
	}
}

