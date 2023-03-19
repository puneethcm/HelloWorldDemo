using System;
namespace HelloWorldDemo
{
	public class CoinFlip
	{
		public static void FindCoinFlip()
		{
			int headCount = 0, tailCount = 0;
			Random random = new Random();
			Console.WriteLine("Press Enter to Fliped the Coin");
			Console.ReadLine();

			while (headCount < 20 || tailCount < 20)
			{
                int number = random.Next(0, 2);
                if (number == 0)
				{
					headCount++;
				}
				else
				{
					tailCount++;
				}
			}
			if (headCount == 20)
			{
				Console.WriteLine("Head Fliped {0} times Head Wins",headCount);
			}
			else
			{
				Console.WriteLine("Tail Fliped {0} times Tail Wins",tailCount);
			}
		}
	}
}

