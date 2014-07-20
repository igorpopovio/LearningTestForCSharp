using System;
using System.Linq;
using NUnit.Framework;

namespace LearningTestForCSharp.Collections
{
    [TestFixture]
    public class DelegatesTests
    {
        [Test]
        public void CollectionFilteringWithPredicates()
        {
            var numbers = Enumerable.Range(1, 5).ToList();
            Predicate<int> isEven = number => number % 2 == 0;
            Assert.That(numbers.FindAll(isEven),
                Is.EquivalentTo(new[] { 2, 4 }));
        }

        [Test]
        public void CollectionFilteringWithLinq()
        {
            var numbers = new[] { 1, 2, 3 };
            Func<int, bool> lessThanTwo = number => number < 2;
            Assert.That(numbers.Where(lessThanTwo),
                Is.EquivalentTo(new[] { 1 }));
        }
    }
}
