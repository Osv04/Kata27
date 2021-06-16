using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata27
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string entrada = "A1SDF2GHJ3KL";
            string expected = "a1sdf2ghj3kl";
            KataSolver kata = new KataSolver();
            string resultado = kata.Solver(entrada);
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string entrada = "ASDFGHJKL";
            string expected = "asdfghjkl";
            KataSolver kata = new KataSolver();
            string resultado = kata.Solver(entrada);
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string entrada = "AsDfGhJKL";
            string expected = "asdfghjkl";
            KataSolver kata = new KataSolver();
            string resultado = kata.Solver(entrada);
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string entrada = "AsDfGhJKL";
            string expected = "Asdfghjkl";
            KataSolver kata = new KataSolver();
            string resultado = kata.Solver(entrada);
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string entrada = "As1DfG3hJK2L";
            string expected = "As1dfg2hjk3l";
            KataSolver kata = new KataSolver();
            string resultado = kata.Solver(entrada);
            Assert.AreEqual(expected, resultado);
        }
    }
}
