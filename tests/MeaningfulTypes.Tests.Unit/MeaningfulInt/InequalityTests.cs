using System;
using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes;

namespace SymbolicTypes.Tests.Unit.MeaningfulInt
{
	public class InequalityTests
	{
        [Test]
        public void GivenDifferentMeaningfulIntsWithDifferentValues_ShouldReturnTrue()
        {
            Age age1 = new Age(1);
            Age age2 = new Age(2);

            (age1 != age2).Should().BeTrue();
        }

        [Test]
        public void GivenTwoMeaningfulIntsWithSameValues_ShouldReturnFalse()
        {
            Age age1 = new Age(1);
            Age age2 = new Age(1);

            (age1 != age2).Should().BeFalse();
        }

        [Test]
        public void GivenOneMeaningfulIntsIsNull_ShouldReturnFalse()
        {
            Age age1 = null;
            Age age2 = new Age(1);

            (age1 != age2).Should().BeTrue();
        }

        [Test]
        public void GivenMeaningfulIntsWithDifferentTypes_ShouldReturnFalse()
        {
            NumberOfPosts numberOfPosts = new NumberOfPosts(1);
            Age age = new Age(1);

            (numberOfPosts != age).Should().BeTrue();
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

