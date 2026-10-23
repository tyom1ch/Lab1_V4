using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Variant4;

namespace Lab1_Variant4.Tests
{
    [TestClass]
    public class ParallelepipedTests
    {
        // Контрольний приклад:
        // Вхідні дані:  a = 1, b = 2, c = 3
        // Вихідні дані: V = 6, S = 22
        private const double A = 1, B = 2, C = 3;
        private const double Delta = 1e-9;

        [TestMethod]
        public void Volume_1_2_3_Returns_6()
        {
            double expected = 6;
            double actual = Program.Volume(A, B, C);
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void SurfaceArea_1_2_3_Returns_22()
        {
            double expected = 22;
            double actual = Program.SurfaceArea(A, B, C);
            Assert.AreEqual(expected, actual, Delta);
        }
    }
}
