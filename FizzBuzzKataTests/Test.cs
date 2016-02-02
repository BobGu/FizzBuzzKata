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
			int Number = 6;
			Process p = new Process ();
			p.StartInfo.FileName = "ipconfig";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.Start ();
			string output = p.StandardOutput.ReadToEnd ();
			p.WaitForExit ();
			FizzBuzz.Evaluate (Number);
			StringAssert.Contains (output, "1 2 Fizz 4 5 Fizz");
		}
	}
}

