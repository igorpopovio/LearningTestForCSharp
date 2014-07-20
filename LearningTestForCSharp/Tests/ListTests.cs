using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LearningTestForCSharp.Tests
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void ListInitialiazer()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.That(list, Is.EquivalentTo(new[] { 1, 2, 3 }));
        }

        [Test]
        public void ListCounts()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.That(list, Has.Count.EqualTo(3));
            Assert.That(list.Count, Is.EqualTo(3));
        }

        [Test]
        public void ListContains()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.That(list.Contains(1), Is.True);
            Assert.That(list, Has.Member(1));

            Assert.That(list.Contains(5), Is.False);
            Assert.That(list, Has.No.Member(5));
        }

        [Test]
        public void RangeCreation()
        {
            var list = Enumerable.Range(-3, 3).ToList();
            var negativeIntegers = new[] { -3, -2, -1 };
            Assert.That(list, Is.EquivalentTo(expected: negativeIntegers));
        }

        [Test]
        public void ConvertAllFromList()
        {
            var negativeNumbers = Enumerable.Range(-3, 3).ToList();
            var positiveNumbers = negativeNumbers.ConvertAll(Math.Abs);
            Assert.That(positiveNumbers, Is.All.Positive);
            Assert.That(positiveNumbers, Is.EquivalentTo(new[] { 1, 2, 3 }));
        }
    }
}