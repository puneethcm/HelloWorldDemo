using System;
namespace HelloWorldDemo
{
	public class Largernumber
	{
		public static void FindLargerNumber(int firstNumb, int secondNumb, int thirdNumb)
		{
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb.CompareTo(thirdNumb) > 0)
            {
                Console.WriteLine("{0} is larger number",firstNumb);
            }
            else if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb.CompareTo(thirdNumb) > 0)
            {
                Console.WriteLine("{0} is larger number",secondNumb);
            }
            else if (thirdNumb.CompareTo(firstNumb) > 0 && thirdNumb.CompareTo(secondNumb) > 0)
            {
                Console.WriteLine("{0} is larger number",thirdNumb);
            }

        }
	}
}

