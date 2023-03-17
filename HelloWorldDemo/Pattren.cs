
using System;
namespace HelloWorldDemo
{
	public class Pattren
	{
		public static void ReversePattrens()
		{
			Console.WriteLine("Enter the number to print * in reverse");
			int number = Convert.ToInt32(Console.ReadLine());

			for (int i= number; i >= 1; i--)
			{
				for(int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

        public static void Pattrens()
        {
            Console.WriteLine("Enter the number to print * ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void ReversePyramidPattren()
        {
            Console.WriteLine("Enter the number to print * ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= (n-i); j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Charector()
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();

            //char[] array = s.ToCharArray();
            string result = "";
            for (int i=0;i<s.Length;i++)
            {
                if (char.IsLower(s[i]))
                {
                    result += s[i].ToString().ToUpper();
                }
                else
                {
                    result += s[i].ToString().ToLower();
                }
            }
            Console.WriteLine(result);
        }
    }
}

