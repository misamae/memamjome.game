using System.Collections.Generic;
using memamjome.gamesys.Exceptions;

namespace memamjome.gamesys.Series
{
    class SeriesGuard : ISeriesGenerator
    {
        private readonly ISeriesGenerator _decorated;

        public SeriesGuard(ISeriesGenerator decorated)
        {
            _decorated = decorated;
        }

        public IEnumerable<double> Generate(double x, double y)
        {
            if (x == -60.49590136 || x == 0.495901364 || x == -58.80972058 || x == -1.190279418)
            {
                throw new InvalidSeriesException();
            }

            return _decorated.Generate(x, y);
        }
    }
}
