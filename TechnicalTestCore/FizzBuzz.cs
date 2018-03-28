namespace TechnicalTestCore
{
	using System;

	internal class FizzBuzz
	{
		public static void PrintFizzBuzzStyleIntegersFrom1Till(string[] args)
		{
			// Write a method body which makes the corresponding unit test in the 'TechnicalTestUnitTest' project pass
			// For this to happen the method needs to do the following:
			// -- It prints the integers from 1 till args[0] to the screen
			// -- One integer per line
			// -- For every multiple of three print 'Fizz'
			// -- For every multiple of five print 'Buzz'
			// -- For every multiple of both three and five print 'FizzBuzz'
			for (int i = 1; i <= int.Parse(args[0]); i++)
			{
				if ((i % 3 == 0) && (i % 5 == 0))
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i.ToString());
				}
			}
		}
	}
}
