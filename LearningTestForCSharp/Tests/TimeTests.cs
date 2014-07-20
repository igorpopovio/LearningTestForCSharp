using System;
using NUnit.Framework;

namespace LearningTestForCSharp.Tests
{
    [TestFixture]
    public class TimeTests
    {
        [Test]
        public void LeapYears()
        {
            Assert.That(DateTime.IsLeapYear(2000));
            Assert.That(DateTime.IsLeapYear(2001), Is.False);
        }
    }
}
