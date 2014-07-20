using System.Linq;
using NUnit.Framework;

namespace LearningTestForCSharp.Collections
{
    [TestFixture]
    public class LinqTests
    {
        [Test]
        public void RestrictionOperators()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;
            Assert.That(evenNumbers,
                Is.EquivalentTo(new[] { 2, 4 }));
        }

        [Test]
        public void PartitioningOperators()
        {
            Assert.That(new[] { 1, 2, 3 }.Take(2),
                Is.EquivalentTo(new[] { 1, 2 }));
        }

        [Test]
        public void Quantifiers()
        {
            var numbers = new[] { 1, 2, 3 };
            Assert.That(numbers.Any(number => number % 2 == 0));
            Assert.That(numbers.All(number => number > 0));
        }
    }
}
