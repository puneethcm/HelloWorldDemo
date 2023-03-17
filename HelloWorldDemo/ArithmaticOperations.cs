using System;
namespace HelloWorldDemo
{
	public class ArithmaticOperations
	{
		public static void ArithmathicOperation()
		{
			Console.WriteLine("\nWelcome to Arithmatic Operations");
			Console.WriteLine("\nChoose any one option \n1:Addition\n2:Substraction\n3:Multiplication\n4:Division");
			int options = Convert.ToInt32(Console.ReadLine());
			switch (options)
			{
				case 1:
                    static void Addition()
                    {
                        Console.WriteLine("Enter X and Y values");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int result = x + y;
                        Console.WriteLine("The sum is " + result);
                    }
                    Addition();
                    break;
				case 2:
                    static void Substraction()
                    {
                        Console.WriteLine("Enter X and Y values");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int result = Math.Abs(x - y);
                        Console.WriteLine("The Differ is " + result);
                    }
                    Substraction();
                    break;
				case 3:
                    static void Multiplication()
                    {
                        Console.WriteLine("Enter X and Y values");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        int result = Math.Abs(x * y);
                        Console.WriteLine("The result is " + result);
                    }
                    Multiplication();
                    break;
                case 4:
                    static void Division()
                    {
                        Console.WriteLine("Enter X and Y values");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        float result = Math.Abs(x / y);
                        Console.WriteLine("The result is " + result);
                    }
                    Division();
                    break;
			}
		}
	}
}

