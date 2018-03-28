using System;
using System.Collections.Generic;
using System.Linq;
namespace TechnicalTestCore
{
    using TechnicalTestUtilities;

    internal class ChildClass : ParentClass
    {
		// Adapt the Childclass definition so that the corresponding unit test in the 'TechnicalTestUnitTests' project will pass
		public override double AnonymousMathematicalFunction(double argument1, double argument2)
		{
			return Math.Pow(argument1,argument2);
		}

	}
}
