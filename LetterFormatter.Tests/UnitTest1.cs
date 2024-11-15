using System.Runtime.Serialization;

namespace LetterFormatter.Tests
{
    public class FormatterTests
    {
        [Test]
        public void Test_ValidInput()
        {
            Assert.Pass(); // Заглушка для тестов
        }

        [Test]
        public void Test_FormatLine_CentersCorrectly()
        {
            Assert.That(Formatter.FormatLine(10, "Hello"), Is.EqualTo("  Hello   "));
        }

    }
}