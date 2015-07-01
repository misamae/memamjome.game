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

        public double GetNthLargetNumber(SeriesPayLoad payLoad, int count, int index)
        {
            var series = _generator.Generate(payLoad, count);

            return index == 0
                ? series.ElementAt(count - 1)
                : series.ElementAt(count - index);
        }

        public double GetClosetSpecialNumber(SeriesPayLoad payLoad, int count, double z)
        {
            var series = _generator.Generate(payLoad, count);
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
