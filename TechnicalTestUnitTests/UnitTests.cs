namespace TechnicalTestUnitTests
{
    // DO NOT change any code in this project
    // The point of the assignment is to make the unit tests pass by writing/modifying code in the TechnicalTestCore project
    using System;
    using FluentAssertions;
    using Xunit;
    using System.IO;
    using TechnicalTestCore;
    using TechnicalTestUtilities;

    public class UnitTests : IDisposable
    {
        private static readonly string Newline = Environment.NewLine;
        private static readonly TextWriter OldOut = Console.Out;
        private static StringWriter _newOut;

        public UnitTests()
        {
            _newOut = new StringWriter();
            Console.SetOut(_newOut);
        }

        public void Dispose()
        {
            Console.SetOut(OldOut);
            _newOut = null;
        }
        
        [Fact]
        public void BooleanVerification()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            TechnicalTestCore.BooleanGenerator.GetBoolean().Should().BeTrue();
        }

        [Fact]
        public void HelloWorld()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            TechnicalTestCore.HelloWorld.SayHelloToTheWorld(null);
            _newOut.ToString().Should().Be("Hello World!" + Newline);
        }

        [Fact]
        public void FizzBuzz_1of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var maxInt = new Random().Next(200);
            TechnicalTestCore.FizzBuzz.PrintFizzBuzzStyleIntegersFrom1Till(new string[] { maxInt.ToString() });
            _newOut.ToString().Should().Be(TestUtilities.GetFizzBuzzOutput(maxInt));
        }

        [Fact]
        public void FizzBuzz_2of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var maxInt = new Random().Next(200, 400);
            TechnicalTestCore.FizzBuzz.PrintFizzBuzzStyleIntegersFrom1Till(new string[] { maxInt.ToString() });
            _newOut.ToString().Should().Be(TestUtilities.GetFizzBuzzOutput(maxInt));
        }

        [Fact]
        public void SumOfSeriesOfConsecutiveNumbers()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var maxNr = new Random().Next(200, 400);
            var observedSum = TechnicalTestCore.Summations.SumOfNumbersFrom1TillNrAsInt(maxNr);
            var expectedSum = TestData.SumOfNumbersFrom1TillMax400Printout[maxNr - 1];
            observedSum.Should().Be(expectedSum);
        }

        [Fact]
        public void SumOfLargerSeriesOfConsecutiveNumbers()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var maxNrAsInt = new Random().Next(70_000, 70_500);
            var maxNrAsString = maxNrAsInt.ToString();
            var observedSum = TechnicalTestCore.Summations.SumOfNumbersFrom1TillNrAsString(maxNrAsString);
            var expectedSum = TestData.SumOfNumbersFrom1TillMin70kMax70k5Printout[maxNrAsInt - 70_000];
            observedSum.Should().Be(expectedSum);
        }

        [Fact]
        public void FindMinimum_1of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var intList = TestData.ListOfRandomNumbersBetween0And1k;
            var observedMinimum = TechnicalTestCore.Minimum.MinimumElementIn(intList);
            const int expectedMinimum = 9;
            observedMinimum.Should().Be(expectedMinimum);
        }

        [Fact]
        public void FindMinimum_2of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            var intList = TestData.ListOfRandomNumbersBetween0And10k;
            var observedMinimum = TechnicalTestCore.Minimum.MinimumElementIn(intList);
            const int expectedMinimum = 1533;
            observedMinimum.Should().Be(expectedMinimum);
        }

        [Fact]
        public void InheritanceAndBasicMath_1of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            const double argument1 = 2d;
            const double argument2 = 10d;
            ParentClass child = GetParentReference(new ChildClass());
            var result = child.AnonymousMathematicalFunction(argument1, argument2);
            result.Should().Be(1024d);
        }

        [Fact]
        public void InheritanceAndBasicMath_2of2()
        {
            // Adapt the relevant code in the 'TechnicalTestCore' project so that this unit test will pass
            // DO NOT change any code in this unit test or this project
            const double argument1 = 3d;
            const double argument2 = 3d;
            ParentClass child = GetParentReference(new ChildClass());
            var result = child.AnonymousMathematicalFunction(argument1, argument2);
            result.Should().Be(27d);
        }

        private static ParentClass GetParentReference(object o)
        {
            if (o is ParentClass)
            {
                ParentClass parentRef = (ParentClass)o;
                return parentRef;
            }
            return null;
        }
    }
}
