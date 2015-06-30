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

            foreach (var item in series)
            {
                if(item > approximateNumber)
                {

                }
            }

            return 0;
        }

        private double GetApproximateNumber(double z)
        {
            return _approximateNumberConstant / z;
        }
    }
}
