namespace RedingtonMiniProject.Tests.Controllers
{
    using System;

    using NUnit.Framework;

    using RedingtonMiniProject.Controllers;

    [TestFixture]
    public class KamilaDominiakInterestControllerTests
    {
        private const double epsilon = 0.0001;

        [TestCase("2018/01/01", "2019/01/01", 0.05, 1.05, TestName = "Test1_Method1")]
        [TestCase("2018/01/01", "2028/01/01", 0.05, 1.643619463, TestName = "Test2_Method1")]
        [TestCase("2020/02/02", "2031/02/02", 0.05, 1.71, TestName = "Test3_Method1")]
        [TestCase("2020/02/02", "2020/05/02", 0.09, 1.023, TestName = "Test4_Method1")]
        public void TestsForMethod1(string startDate, string endDate, double interest, double expectedResult)
        {
            var sut = new InterestController();
            var result = sut.CalculateInterest1(DateTime.Parse(startDate), DateTime.Parse(endDate), interest);

            Assert.AreEqual(expectedResult, result, epsilon);
        }

        [TestCase("2018/01/01", "2019/01/01", 0.05, 1.05, TestName = "Test1_Method2")]
        [TestCase("2018/01/01", "2028/01/01", 0.05, 1.71, TestName = "Test2_Method2")]
        [TestCase("2020/02/02", "2031/02/02", 0.05, 1.71, TestName = "Test3_Method2")]
        [TestCase("2020/02/02", "2020/05/02", 0.09, 1.023, TestName = "Test4_Method2")]
        public void TestsForMethod2(string startDate, string endDate, double interest, double expectedResult)
        {
            var sut = new InterestController();
            var result = sut.CalculateInterest1(DateTime.Parse(startDate), DateTime.Parse(endDate), interest);

            Assert.AreEqual(expectedResult, result, epsilon);
        }
    }
}