using NUnit.Framework;
using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class FizzBuzzUnitTests
    {
        [Test]
        public void ExampleFromTask_ShouldMatchExpected()
        {
            string input = "Mary had a little lamb\nLittle lamb, little lamb\nMary had a little lamb\nIt's fleece was white as snow";
            var detector = new FizzBuzzDetector();
            var result = detector.GetOverlappings(input);

            Assert.AreEqual(9, result.Count);
        }

        [Test]
        public void ShortText_NoFizzBuzz()
        {
            string input = "One two";
            var detector = new FizzBuzzDetector();
            var result = detector.GetOverlappings(input);

            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void OnlyFizzBuzzCases()
        {
            string input = "a b c d e f g h i j k l m n o";
            var detector = new FizzBuzzDetector();
            var result = detector.GetOverlappings(input);

            Assert.Greater(result.Count, 0);
        }

        [Test]
        public void MinLength()
        {
            string input = "Hello me you";
            var detector = new FizzBuzzDetector();
            var result = detector.GetOverlappings(input);

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void MaxLengthBoundary()
        {
            string input = new string('a', 100);
            var detector = new FizzBuzzDetector();
            Assert.DoesNotThrow(() => detector.GetOverlappings(input));
        }
    }
}
