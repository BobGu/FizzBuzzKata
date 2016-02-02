using System;

namespace FizzBuzzKata
{
	public class FizzBuzz
	{
		public static void Main (string[] args)
		{
			
		}
		public static bool DivisibleByThree(int Number)
		{
			return Number % 3 == 0;
		}

		public static void Evaluate(int Number)
		{
			for (int i = 1; i <= Number; i++)
			{
				if (DivisibleByThree (i))
				{
					Console.WriteLine ("Fizz");
				}
				else
				{
					Console.WriteLine (i);
				}
			}
		}
	}
}
