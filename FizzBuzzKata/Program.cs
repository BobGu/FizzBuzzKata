using System;

namespace FizzBuzzKata
{
	public class FizzBuzz
	{
		public static void Main(string[] args)
		{
			
		}
		public static bool DivisibleByThree(int Number)
		{
			return Number % 3 == 0;
		}

		public static bool DivisibleByFive(int Number)
		{
			return Number % 5 == 0;
		}

		public static void OutputStream(string message)
		{
			Console.WriteLine(message);
		}


		public static void Evaluate(int number)
		{
			for (int i = 1; i <= number; i++)
			{
				if (DivisibleByThree(i) & DivisibleByFive(i))
				{
					OutputStream("FizzBuzz");
				}
				else if (DivisibleByThree(i))
				{
					OutputStream("Fizz");
				}
				else if (DivisibleByFive(i))
				{
					OutputStream("Buzz");
				}
				else
				{
					OutputStream(i.ToString());
				}
			}
		}
	}
}
