#region Usings

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedingtonMiniProject.Helpers;
using RedingtonMiniProject.Helpers.Exceptions;
using RedingtonMiniProject.Models;

#endregion

namespace RedingtonMiniProject.Tests.Controllers
{
    [TestClass]
    public class ProbabilityCalculatorToolTests
    {
        [TestMethod]
        public void CombineWithPositiveTest1()
        {
            var result = ProbabilityCalculatorTool.CombineWith(0.5, 0.5);
            Assert.AreEqual(result, 0.25);
        }

        [TestMethod]
        public void EitherPositiveTest1()
        {
            var result = ProbabilityCalculatorTool.Either(0.5, 0.5);
            Assert.AreEqual(result, 0.75);
        }

        [TestMethod]
        public void CombineWithNegativeTest1()
        {
            try
            {
                ProbabilityCalculatorTool.CombineWith(-0.1, 0.5);
            }
            catch (ProbabilityCalculatorOutOfRangeException)
            {
                return;
            }

            throw new Exception("Test did not ended on valid exception");
        }

        [TestMethod]
        public void EitherNegativeTest1()
        {
            try
            {
                ProbabilityCalculatorTool.Either(-0.1, 0.5);
            }
            catch (ProbabilityCalculatorOutOfRangeException)
            {
                return;
            }

            throw new Exception("Test did not ended on valid exception");
        }

        [TestMethod]
        public void CombineWithNegativeTest2()
        {
            try
            {
                ProbabilityCalculatorTool.CombineWith(0.5, 1.00001);
            }
            catch (ProbabilityCalculatorOutOfRangeException)
            {
                return;
            }

            throw new Exception("Test did not ended on valid exception");
        }

        [TestMethod]
        public void EitherNegativeTest2()
        {
            try
            {
                ProbabilityCalculatorTool.Either(0.5, 1.00001);
            }
            catch (ProbabilityCalculatorOutOfRangeException)
            {
                return;
            }

            throw new Exception("Test did not ended on valid exception");
        }
    }
}