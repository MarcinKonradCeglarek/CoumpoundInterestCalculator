namespace RedingtonMiniProject.Tests.Controllers
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RedingtonMiniProject.Controllers;

    [TestClass]
    public class InterestControllerTests
    {
        [TestMethod]
        public void CalculateInterest1_TwoYears()
        {
            var startDate = new DateTime(2020, 01, 01);
            var endDate = new DateTime(2022, 01, 01);
            var interest = 0.05;

            var ctrl = new InterestController();

            // Act
            var result = ctrl.CalculateInterest1(startDate, endDate, interest);

            Assert.AreEqual(0.1025, result);
        }

        [TestMethod]
        public void CalculateInterest2()
        {
            var startDate = new DateTime(2020, 01, 01);
            var endDate = new DateTime(2022, 01, 01);
            var interest = 0.05;

            var ctrl = new InterestController();

            // Act
            var result = ctrl.CalculateInterest1(startDate, endDate, interest);

            Assert.AreEqual(0.1025, result);
        }

        [TestMethod]
        public void CalculateInterest3()
        {
            var startDate = new DateTime(2020, 01, 01);
            var endDate = new DateTime(2022, 01, 01);
            var interest = 0.05;

            var ctrl = new InterestController();

            // Act
            var result = ctrl.CalculateInterest2(startDate, endDate, interest);

            Assert.AreEqual(0.1025, result);
        }
    }
}