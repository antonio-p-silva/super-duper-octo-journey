using System;
using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes;
using ShowIntent.SymbolicTypes.Extensions;

namespace SymbolicTypes.Tests.Unit
{
    public class MeaningfulIntegerSumTest
    {
        private class Age : MeaningfulInteger
        {
            public Age(int value) : base(value)
            {
            }
        }
        
        [TestCase(12, 12, 24)]
        [TestCase(0, 12, 12)]
        [TestCase(100, 0, 100)]
        [TestCase(5, 5, 10)]
        [TestCase(0, 0, 0)]
        public void GivenTwoDifferentAges_ShouldReturnSumOfAges(int ageOne, int ageTwo, int expectedAge)
        {
            Age firstAge = new Age(ageOne);
            Age secondAge = new Age(ageTwo);
            firstAge.Add(secondAge).Should().Be(new Age(expectedAge));
        }
        
        [Test]
        public void GivenFirstAgeIsNull_ShouldThrowException()
        {
            Age firstAge = null;
            Age secondAge = new Age(30);
            Action sut = () => firstAge.Add(secondAge);
            sut.Should().ThrowExactly<ArgumentNullException>();
        }
        
        [Test]
        public void GivenSecondAgeIsNull_ShouldReturnFalse()
        {
            Age firstAge = null;
            Age secondAge = new Age(30);
            Action sut = () => firstAge.Add(secondAge);
            sut.Should().ThrowExactly<ArgumentNullException>();
        }
    }
}