using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memamjome.gamesys.Series
{
    class SeriesGenerator : ISeriesGenerator, IEnumerable<double>
    {
        private static double GetFirstNumber(double x)
        {
            return ((0.5 * x * x) + (30.0 * x) + 10.0) / 25.0;
        }

        private static double GetGrowthRate(double y, double firstNumber)
        {
            return y / (firstNumber * 1250.0);
        }

        public IEnumerable<double> Generate(double x, double y)
        {
            var firstNumber = GetFirstNumber(x);
            var growthRate = GetGrowthRate(y, firstNumber);
            var current = firstNumber;

            yield return firstNumber;

            current = firstNumber * growthRate;
            yield return current;

            while(true)
            {
                var value = current * firstNumber;
                yield return value;
                current = value;
            }
        }

        public IEnumerator<double> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
