using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes;

namespace SymbolicTypes.Tests.Unit
{
    public class MeaningfulStringTests
    {
        
        [Test]
        public void GivenOneCustomerNameIsNullAndTheOtherCustomerNameHasValue_WhenUsingEqualOperator_ShouldReturnFalse()
        {
            CustomerName firstCustomerName = null;
            CustomerName secondCustomerName = new CustomerName("silva");
            (firstCustomerName == secondCustomerName).Should().BeFalse();
        }
        [Test]
        public void GivenOneCustomerNameIsNullAndTheOtherCustomerNameHasValue_WhenUsingDifferentOperator_ShouldReturnTrue()
        {
            CustomerName firstCustomerName = null;
            CustomerName secondCustomerName = new CustomerName("silva");
            (firstCustomerName != secondCustomerName).Should().BeTrue();
        }
        
        [Test]
        public void GivenTwoCustomerNamesAreDifferent_WhenUsingDifferentOperator_ShouldReturnTrue()
        {
            CustomerName firstCustomerName = new CustomerName("antonio");
            CustomerName secondCustomerName = new CustomerName("silva");
            (firstCustomerName != secondCustomerName).Should().BeTrue();
        }
        
        [Test]
        public void GivenTwoCustomerNamesAreDifferent_WhenUsingEqualOperator_ShouldReturnFalse()
        {
            CustomerName firstCustomerName = new CustomerName("antonio");
            CustomerName secondCustomerName = new CustomerName("silva");
            (firstCustomerName == secondCustomerName).Should().BeFalse();
        }
        
        [Test]
        public void GivenTwoCustomerNamesAreEqual_WhenUsingEqualOperator_ShouldReturnTrue()
        {
            CustomerName firstCustomerName = new CustomerName("antonio");
            CustomerName secondCustomerName = new CustomerName("antonio");
            (firstCustomerName == secondCustomerName).Should().BeTrue();
        }
        
        private class CustomerName : MeaningfulString
        {
            public CustomerName(string value) : base(value)
            {
            }
        }
    }
}