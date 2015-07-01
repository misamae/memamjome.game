using System;
using System.Linq;
using memamjome.gamesys.Series;

namespace memamjome.gamesys.SpeicalNumbers
{
    public class SpecialNumberFinder
    {
        private readonly SeriesGeneratorFacade _generator;
        private readonly double _approximateNumberConstant;

        public SpecialNumberFinder(SeriesGeneratorFacade generator, double approximateNumberConstant)
        {
            _generator = generator;
            _approximateNumberConstant = approximateNumberConstant;
        }

        public double GetNthLargetNumber(double x, double y, int count, int index)
        {
            var series = _generator.Generate(x, y, count);

            return index == 0
                ? series.ElementAt(count - 1)
                : series.ElementAt(count - index);
        }

        public double GetClosetSpecialNumber(double x, double y, int count, double z)
        {
            var series = _generator.Generate(x, y, count);
            var approximateNumber = GetApproximateNumber(z);

            var deltas = series.Select((d, i) => new {index = i, diff = Math.Abs(d - approximateNumber)})
                .OrderBy(d => d.diff).ThenByDescending(d => d.index);

            return series.ElementAt(deltas.ElementAt(0).index);
        }

        private double GetApproximateNumber(double z)
        {
            return _approximateNumberConstant / z;
        }
    }
}
