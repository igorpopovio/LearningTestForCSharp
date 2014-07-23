using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LearningTestForCSharp.Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        [Test]
        public void Generator()
        {
            var numbers = Enumerable.Range(1, 10);
            var expectedEvenNumbers = new[] { 2, 4, 6, 8, 10 };
            Assert.That(FindAllEvenNumbersWithGenerator(numbers), Is.EquivalentTo(expectedEvenNumbers));
            Assert.That(FindAllEvenNumbersWithoutGenerator(numbers), Is.EquivalentTo(expectedEvenNumbers));
        }

        private IEnumerable<int> FindAllEvenNumbersWithoutGenerator(IEnumerable<int> numbers)
        {
            var evenNumbers = new List<int>();
            foreach (var number in numbers)
                if (number % 2 == 0)
                    evenNumbers.Add(number);
            return evenNumbers;
        }

        public IEnumerable<int> FindAllEvenNumbersWithGenerator(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
                if (number % 2 == 0)
                    yield return number;
        }
    }
}
