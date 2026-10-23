using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Example_5_and_6_Returns_11()
        {
            // Вхідні дані: перше число 5, друге число 6
            int a = 5;
            int b = 6;
            int expected = 11;      // Вихідні дані: сума чисел 11

            int actual = Program.Example(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
