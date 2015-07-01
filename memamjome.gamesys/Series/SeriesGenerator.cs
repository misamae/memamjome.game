using System;
using System.Collections.Generic;

namespace memamjome.gamesys.Series
{
    class SeriesGenerator : ISeriesGenerator
    {
        private static double GetFirstNumber(double x)
        {
            return ((0.5 * x * x) + (30.0 * x) + 10.0) / 25.0;
        }

        private static double GetGrowthRate(double y, double firstNumber)
        {
            return y / (firstNumber * 1250.0);
        }

        public IEnumerable<double> Generate(SeriesPayLoad payload)
        {
            var firstNumber = GetFirstNumber(payload.X);
            var growthRate = GetGrowthRate(payload.Y, firstNumber);
            var current = firstNumber;

            yield return firstNumber;

            current = firstNumber * growthRate;
            yield return current;

            while (true)
            {
                var value = current * firstNumber;
                yield return value;
                current = value;
            }
        }
    }
}
