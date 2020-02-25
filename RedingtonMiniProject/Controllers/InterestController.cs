namespace RedingtonMiniProject.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;

    using WebGrease.Css.Extensions;

    public class InterestController : ApiController
    {
        private const double DaysInYear = 365;

        [HttpGet]
        public double CalculateInterest1(DateTime startDate, DateTime endDate, double yearlyInterestRate)
        {
            var result = 1.0;
            var quarterlyInterestRate = yearlyInterestRate / 4;
            var monthsCount = (endDate.Month + endDate.Year * 12) - (startDate.Month + startDate.Year * 12);
            for (int i = 0; i < monthsCount / 3; i++)
            {
                result = result * (1 + quarterlyInterestRate);
            }

            return result;
        }

        [HttpGet]
        public double CalculateInterest2(DateTime startDate, DateTime endDate, double yearlyInterestRate)
        {
            var result = 1.0;
            var quarterlyInterestRate = yearlyInterestRate / 4;
            var monthsCount = (endDate.Month + endDate.Year * 12) - (startDate.Month + startDate.Year * 12);

            if (endDate.Day <= startDate.Day)
            {
                monthsCount--;
            }

            for (int i = 0; i < monthsCount / 3; i++)
            {
                result = result * (1 + quarterlyInterestRate);
            }

            return result;
        }
    }
}