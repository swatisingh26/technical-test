namespace TechnicalTestCore
{
    using System.Collections.Generic;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int min = intlist[0];
            for (int i = 1; i < intlist.Count; i++)
            {
                if (intlist[i] < min)
                {
                    min = intlist[i];
                }
            }
            return min;
        }
    }
}
