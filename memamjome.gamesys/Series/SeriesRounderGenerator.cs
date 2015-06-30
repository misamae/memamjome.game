using System.Collections.Generic;
using System.Linq;

namespace memamjome.gamesys.Series
{
    class SeriesRounderGenerator : ISeriesGenerator
    {
        private readonly ISeriesGenerator _decorated;

        public SeriesRounderGenerator(ISeriesGenerator decorated)
        {
            _decorated = decorated;
        }

        public static double RoundDecimal25(double number)
        {
            return System.Math.Round(number * 4.0, System.MidpointRounding.ToEven) / 4.0;
        }

        public IEnumerable<double> Generate(double x, double y)
        {
            return _decorated.Generate(x, y).Select(d => RoundDecimal25(d));
        }
    }
}
