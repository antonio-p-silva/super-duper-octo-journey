using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes.Extensions;

namespace SymbolicTypes.Tests.Unit
{
    public class MeaningfulStringExtensionsTests
    {
        [Test]
        public void GivenCustomerNameIsNotNull_WhenUsingIsDefined_ShouldReturnTrue()
        {
            CustomerName name = new CustomerName("antonio");
            name.IsDefined().Should().BeTrue();
        }    
        
        [Test]
        public void GivenCustomerNameIsNull_WhenUsingIsDefined_ShouldReturnFalse()
        {
            CustomerName name = null;
            name.IsDefined().Should().BeFalse();
        }    
        
        private class CustomerName : ShowIntent.SymbolicTypes.MeaningfulString
        {
            public CustomerName(string value) : base(value)
            {
            }
        }
    }
}