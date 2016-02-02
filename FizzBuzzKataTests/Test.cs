using NUnit.Framework;
using System;
using System.IO;
using System.Diagnostics;
using FizzBuzzKata;

namespace FizzBuzzKataTests
{
	[TestFixture]
	public class FizzBuzzKataTests
	{
		[Test]
		public void CanDivideByThree ()
		{
			int Number = 3;
			bool Result = FizzBuzz.DivisibleByThree (Number);
			Assert.IsTrue (Result, "Should return treu when it can divide by three");
			int Number2 = 5;
			bool Result2 = FizzBuzz.DivisibleByThree (Number2);
			Assert.IsFalse (Result2, "Should return false when can't divide by three");
		}

		[Test]
		public void PrintsFizz ()
		{
			using (StringWriter sw = new StringWriter ())
			{
				int Number = 4;
				Console.SetOut (sw);
				FizzBuzz.Evaluate (Number);
				string output = sw.ToString().Replace("\n", " ").Trim ();
				StringAssert.AreEqualIgnoringCase("1 2 Fizz 4", output);
			}
		}

		[Test]
		public void CanDivideByFive ()
		{
			int Number = 5;
			bool Result = FizzBuzz.DivisibleByFive (Number);
			Assert.IsTrue (Result, "Should return true when divisible by 5");
		}

		[Test]
		public void PrintsFizzOrBuzz ()
		{
			using (StringWriter sw = new StringWriter ())
			{
				int Number = 6;
				Console.SetOut (sw);
				FizzBuzz.Evaluate (Number);
				string output = sw.ToString().Replace("\n", " ").Trim ();
				StringAssert.AreEqualIgnoringCase("1 2 Fizz 4 Buzz Fizz", output);
			}
		}

		[Test]
		public void PrintsFizzBuzz()
		{
			using (StringWriter sw = new StringWriter ())
			{
				int Number = 15;
				Console.SetOut (sw);
				FizzBuzz.Evaluate (Number);
				string output = sw.ToString().Replace("\n", " ").Trim();
				StringAssert.AreEqualIgnoringCase("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", output);
			}
		}
	}
}

