namespace TechnicalTestUtilities
{
    // DO NOT change any code in this project
    // The point of the assignment is to make the unit tests pass by writing/modifying code in the TechnicalTestCore project
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TestUtilities
    {
        public static string GetFizzBuzzOutput(int maxInt)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < maxInt; i++)
            {
                stringBuilder.AppendLine(TestData.FizzBuzzPrintoutUpTo400[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
