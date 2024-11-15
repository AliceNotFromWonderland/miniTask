using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Runtime.Serialization;

namespace LetterFormatter.Tests
{
    public class FormatterTests
    {

        [Test]
        public void FormatLetter_ShouldCenterAlignLines()
        {
            int k = 10;
            int n = 3;
            string[] input = { "Hi", "Test", "World" };
            string[] expected = { "    Hi    ", "   Test   ", "  World   " };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FormatLetter_ShouldReturnImpossible_WhenLineTooLong()
        {
            int k = 5;
            int n = 1;
            string[] input = { "TooLong" };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(new[] { "Impossible." }), "Expected 'Impossible.' when a line cannot be formatted.");
        }

        [Test]
        public void FormatLetter_SingleLineExactLength()
        {
            int k = 5;
            int n = 1;
            string[] input = { "Hello" };
            string[] expected = { "Hello" };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FormatLetter_MinimumWidth()
        {
            int k = 1;
            int n = 1;
            string[] input = { "A" };
            string[] expected = { "A" };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FormatLetter_EmptyInput()
        {
            int k = 5;
            int n = 0;
            string[] input = { };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(Array.Empty<string>()), "Expected empty output for empty input.");
        }

        [Test]
        public void FormatLetter_UnbalancedSpaces()
        {
            int k = 7;
            int n = 1;
            string[] input = { "Hi" };
            string[] expected = { "  Hi   " }; // 2 пробела слева, 3 справа

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FormatLetter_MixedInput()
        {
            int k = 8;
            int n = 3;
            string[] input = { "A", "Bigger", "Test" };
            string[] expected = { "   A    ", " Bigger ", "  Test  " };

            var result = Program.FormatLetter(k, n, input);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}