using System;
namespace HelloWorldDemo
{
	public class Addmission
	{
		public static void EligibleForAdmission()
		{
			Console.WriteLine("Enter Maths marks");
			int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics marks");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks");
            int chemistry = Convert.ToInt32(Console.ReadLine());

			int totalMarks = maths + physics + chemistry;
			int mathsAndPhysics = maths + physics;
			int mathsAndChemistry = maths + chemistry;

			if(maths<=65 && physics<=55 && chemistry <= 50 || totalMarks <= 180)
			{
				Console.WriteLine("Candidate is not eligible for Admission");
			}
			else if (mathsAndPhysics<=140 || mathsAndChemistry <= 140)
			{
                Console.WriteLine("Candidate is not eligible for Admission");
            }
			else
			{
                Console.WriteLine("Candidate is eligible for Admission");
            }
        }
	}
}

