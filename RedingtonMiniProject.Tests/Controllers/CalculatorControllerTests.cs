#region Usings

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedingtonMiniProject.Controllers;

#endregion

namespace RedingtonMiniProject.Tests.Controllers
{
    [TestClass]
    public class CalculatorControllerTests
    {
        [TestMethod]
        public void CombineWithNegativeTest1()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.CombineWith(-1, 0);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CombineWithNegativeTest2()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.CombineWith(0.5, 1.0000001);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CombineWithNegativeTest3()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.CombineWith(-0.001, 0.3);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CombineWithNegativeTest4()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.CombineWith(4, 2);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void EitherNegativeTest1()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.Either(-1, 0);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void EitherNegativeTest2()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.Either(0.5, 1.0000001);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void EitherNegativeTest3()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.Either(-0.001, 0.3);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void EitherNegativeTest4()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.Either(4, 2);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void EitherPositiveTest1()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.Either(0.5, 0.5);
            Assert.AreEqual(result, 0.75);
        }

        [TestMethod]
        public void CombineWithPositiveTest1()
        {
            var ctrl = new CalculatorController();
            var result = ctrl.CombineWith(0.5, 0.5);
            Assert.AreEqual(result, 0.25);
        }
    }
}