using System;

namespace Task1Logic
{
    public class Logic
    {
        /// <summary>
        /// Returns the root of the n-th degree
        /// </summary>
        /// <param name="value">Radicant</param>
        /// <param name="eps">The required accuracy</param>
        /// <param name="approx">The initial approximation</param>
        /// <param name="degree">The required degree</param>
        /// <returns>Returns the root of the n-th degree</returns>
        public static double RecordRoot(double value, double eps, double degree, double approx = 1)
        {
            if (value == 0)
                return 0;
            if (approx == 0)
            {
                Console.WriteLine("The initial approximation for this function can't be equal to 0! Changing it to default...");
                approx = 1;
            }
            double current = (((degree - 1) * approx) + value / (Math.Pow(approx, degree - 1))) / degree;
            return Math.Abs(current - approx) < eps ? current : RecordRoot(value, eps, degree, current);
        }
    }
}
