using RedingtonMiniProject.Helpers.Exceptions;

namespace RedingtonMiniProject.Helpers
{
    public static class ProbabilityCalculatorTool
    {
        public static double CombineWith(double a, double b)
        {
            ValidateProbability(a);
            ValidateProbability(b);
            return a*b;
        }

        public static double Either(double a, double b)
        {
            // Validation is not required - CombineWith will chech constraints
            return (a + b) - CombineWith(a,b);
        }

        private static void ValidateProbability(double p)
        {
            if (p >= 0.0 && p <= 1.0)
            {
                return;
            }

            throw new ProbabilityCalculatorOutOfRangeException();
        }
    }
}