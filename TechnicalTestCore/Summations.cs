namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int sumFrom1TillMaxNrAsInt = (maxNrAsInt * (maxNrAsInt + 1)) / 2;
            return sumFrom1TillMaxNrAsInt;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            long maxNrAsInt = System.Convert.ToInt64(maxNrAsString);
            long sumFrom1TillMaxNrAsInt = (maxNrAsInt * (maxNrAsInt + 1)) / 2;
            return sumFrom1TillMaxNrAsInt.ToString();
        }
    }
}
