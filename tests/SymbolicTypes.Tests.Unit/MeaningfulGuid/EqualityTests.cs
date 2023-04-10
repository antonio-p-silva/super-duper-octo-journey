
using System;
using FluentAssertions;
using NUnit.Framework;
using ShowIntent.SymbolicTypes;

namespace SymbolicTypes.Tests.Unit
{
	public class EqualityTests
	{
		[Test]
		public void GivenDifferentMeaningfulGuidsWithDifferentValues_ShouldReturnFalse()
		{
            SubmissionId submission1 = new SubmissionId(Guid.NewGuid());
            SubmissionId submission2 = new SubmissionId(Guid.NewGuid());

            (submission1 == submission2).Should().BeFalse();
        }

        [Test]
        public void GivenTwoMeaningfulGuidsWithSameValues_ShouldReturnFalse()
        {
            Guid uniqueValue = Guid.NewGuid();
            SubmissionId submission1 = new SubmissionId(uniqueValue);
            SubmissionId submission2 = new SubmissionId(uniqueValue);

            (submission1 == submission2).Should().BeTrue();
        }

        [Test]
        public void GivenOneMeaningfulGuidsIsNull_ShouldReturnFalse()
        {
            Guid uniqueValue = Guid.NewGuid();
            SubmissionId submission1 = null;
            SubmissionId submission2 = new SubmissionId(uniqueValue);

            (submission1 == submission2).Should().BeFalse();
        }

        [Test]
        public void GivenMeaningfulGuidsWithDifferentTypes_ShouldReturnFalse()
        {
            Guid uniqueValue = Guid.NewGuid();
            RequestId requestId = new RequestId(uniqueValue);
            SubmissionId submission2 = new SubmissionId(uniqueValue);

            (requestId == submission2).Should().BeFalse();
        }

        private class SubmissionId : MeaningfulGuid
        {
            public override Guid Value { get; }

            public SubmissionId(Guid value)
            {
                Value = value;
            }
        }

        private class RequestId : MeaningfulGuid
        {
            public override Guid Value { get; }

            public RequestId(Guid value)
            {
                Value = value;
            }
        }
    }
}

