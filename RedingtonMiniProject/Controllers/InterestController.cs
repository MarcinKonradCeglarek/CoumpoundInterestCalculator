namespace RedingtonMiniProject.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;

    using WebGrease.Css.Extensions;

    public class InterestController : ApiController
    {
        const double daysInYear = 365;

        [HttpGet]
        public double CalculateInterest1(DateTime startDate, DateTime endDate, double yearlyInterestRate)
        {
            var difference = endDate.Year - startDate.Year;
            return yearlyInterestRate * difference;
        }

        [HttpGet]
        public double CalculateInterest2(DateTime startDate, DateTime endDate, double yearlyInterestRate)
        {
            var difference = new DateTime(endDate.Year, endDate.Month, endDate.Day) - new DateTime(startDate.Year, startDate.Month, startDate.Day);
            return Math.Pow(1 + (yearlyInterestRate / daysInYear), difference.TotalDays) - 1;
        }

        [HttpGet]
        public double CalculateInterest3(DateTime startDate, DateTime endDate, double yearlyInterestRate)
        {
            var difference = endDate - startDate;
            var dailyInterest = 1 + (yearlyInterestRate / daysInYear);
            double result = 1.0;
            Enumerable.Range(0, (int)difference.TotalDays).ForEach(i => result = result * dailyInterest);
            return result - 1;
        }
    }
}