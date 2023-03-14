using System;
namespace HelloWorldDemo
{
	public class ReverseProgram
	{
		public void ReverseString()
		{
			Console.WriteLine("Enter the word");
			string word = Console.ReadLine();

			char[] array = word.ToCharArray();
			Console.WriteLine("After reverse");
			for (int i = word.Length-1; i>=0; i--)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}

