using FluentAssertions;
using NUnit.Framework;

namespace SymbolicTypes.Tests.Unit.MeaningfulInt
{
    [TestFixture]
	public class EqualityTests
	{
		[Test]
		public void GivenDifferentMeaningfulIntsWithDifferentValues_ShouldReturnFalse()
		{
            Age age1 = new Age(1);
            Age age2 = new Age(2);

            (age1 == age2).Should().BeFalse();
        }

        [Test]
        public void GivenTwoMeaningfulIntsWithSameValues_ShouldReturnFalse()
        {
            Age age1 = new Age(1);
            Age age2 = new Age(1);

            (age1 == age2).Should().BeTrue();
        }

        [Test]
        public void GivenOneMeaningfulIntIsNull_ShouldReturnFalse()
        {
            Age age1 = null;
            Age age2 = new Age(2);

            (age1 == age2).Should().BeFalse();
        }

        [Test]
        public void GivenMeaningfulIntWithDifferentTypes_ShouldReturnFalse()
        {
            Age age = new Age(1);
            NumberOfPosts numberOfPosts = new NumberOfPosts(1);

            (age == numberOfPosts).Should().BeFalse();
        }

        private class Age : ShowIntent.SymbolicTypes.MeaningfulInt
        {
            public override int Value { get; }

            public Age(int value)
            {
                Value = value;
            }
        }

        private class NumberOfPosts : ShowIntent.SymbolicTypes.MeaningfulInt
        {
            public override int Value { get; }

            public NumberOfPosts(int value)
            {
                Value = value;
            }
        }
    }
}

