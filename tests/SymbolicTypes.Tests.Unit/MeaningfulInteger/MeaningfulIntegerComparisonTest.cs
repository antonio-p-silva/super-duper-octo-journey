using System;
using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes;
using ShowIntent.SymbolicTypes.Extensions;

namespace SymbolicTypes.Tests.Unit
{
    public class MeaningfulIntegerComparisonTest
    {
        private class Age : MeaningfulInteger
        {
            public Age(int value) : base(value)
            {
            }
        }
        
        [Test]
        public void GivenTwoDifferentAges_ShouldReturnFalse()
        {
            Age firstAge = new Age(12);
            Age secondAge = new Age(30);
            (firstAge == secondAge).Should().BeFalse();
        }
        
        [Test]
        public void GivenFirstAgeIsNull_ShouldReturnFalse()
        {
            Age firstAge = null;
            Age secondAge = new Age(30);
            (firstAge == secondAge).Should().BeFalse();
        }
        
        [Test]
        public void GivenSecondAgeIsNull_ShouldReturnFalse()
        {
            Age firstAge = new Age(12);
            Age secondAge = null;
            
            (firstAge == secondAge).Should().BeFalse();
        }
    }
    
    public class MeaningfulIntegerSumTest
    {
        private class Age : MeaningfulInteger
        {
            public Age(int value) : base(value)
            {
            }
        }
        
        [Test]
        public void GivenTwoDifferentAges_ShouldReturnFalse()
        {
            Age firstAge = new Age(12);
            Age secondAge = new Age(30);
            firstAge.Add(secondAge).Should().Be(new Age(42));
        }
        
        [Test]
        public void GivenFirstAgeIsNull_ShouldReturnFalse()
        {
            Age firstAge = null;
            Age secondAge = new Age(30);
            firstAge.Add(secondAge).Should().Be(new Age(30));
        }
        
        [Test]
        public void GivenSecondAgeIsNull_ShouldReturnFalse()
        {
            Age firstAge = new Age(12);
            Age secondAge = null;
            firstAge.Add(secondAge).Should().Be(new Age(12));
        }
        
        [Test]
        public void GivenSecondAgeIsNull_ShouldReturnFalse3()
        {
            Age firstAge = null;
            Age secondAge = null;
            firstAge.Add(secondAge).Should().BeNull();
        }
    }
}