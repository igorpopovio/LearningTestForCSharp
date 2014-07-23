using System;
using System.Linq;
using NUnit.Framework;

namespace LearningTestForCSharp.Tests
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

        delegate void Operation(Logger logger);

        event Operation OnOperation;

        void FirstOperation(Logger logger)
        {
            logger.Message += "FirstOperation\n";
        }

        void SecondOperation(Logger logger)
        {
            logger.Message += "SecondOperation\n";
        }

        [Test]
        public void AllDelegatesAreCalledForAnEvent()
        {
            var logger = new Logger();

            OnOperation += FirstOperation;
            OnOperation += SecondOperation;
            OnOperation(logger);

            Assert.That(logger.Message, Is.EqualTo("FirstOperation\nSecondOperation\n"));
        }

        class Logger
        {
            public string Message;
        }
    }
}
