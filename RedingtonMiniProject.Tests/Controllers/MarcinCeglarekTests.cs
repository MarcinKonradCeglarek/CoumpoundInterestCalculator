namespace RedingtonMiniProject.Tests.Controllers
{
    using System;

    using NUnit.Framework;

    using Ploeh.AutoFixture;

    using RedingtonMiniProject.Controllers;

    [TestFixture]
    public class MarcinCeglarekInterestControllerTests
    {
        private static double epsilon = 0.001;
        public static Fixture fixture = new Fixture();

        [Test(ExpectedResult = 1.0)]
        public double OneDay_NoInterest_Method1()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddDays(1);

            var interest = fixture.Create<double>();

            var sut = new InterestController();
            var result = sut.CalculateInterest1(date1, date2, interest);

            return result;
        }

        [Test]
        public void OneDay_NoInterest_Method2()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddDays(1);

            var interest = fixture.Create<double>();

            var sut = new InterestController();
            var result = sut.CalculateInterest2(date1, date2, interest);

            Assert.AreEqual(1.0, result, epsilon);
        }

        [Test]
        public void NotFullThreeMonths_NoInterest_Method1()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddMonths(3);

            var interest = fixture.Create<double>();

            var sut = new InterestController();
            var result = sut.CalculateInterest1(date1, date2, interest);

            Assert.AreEqual(1.0, result, epsilon);
        }

        [Test]
        public void NotFullThreeMonths_NoInterest_Method2()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddMonths(3);

            var interest = fixture.Create<double>();

            var sut = new InterestController();
            var result = sut.CalculateInterest2(date1, date2, interest);

            Assert.AreEqual(1.0, result, epsilon);
        }

        [Test]
        public void FullThreeMonths_SingleInterest_Method1()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddMonths(3).AddDays(1);

            var interest = 0.05;

            var sut = new InterestController();
            var result = sut.CalculateInterest1(date1, date2, interest);

            Assert.AreEqual(1.0125, result, epsilon);
        }

        [Test]
        public void FullThreeMonths_SingleInterest_Method2()
        {
            var date1 = fixture.Create<DateTime>();
            var date2 = date1.AddMonths(3).AddDays(1);

            var interest = 0.05;

            var sut = new InterestController();
            var result = sut.CalculateInterest2(date1, date2, interest);

            Assert.AreEqual(1.0125, result, epsilon);
        }
    }
}