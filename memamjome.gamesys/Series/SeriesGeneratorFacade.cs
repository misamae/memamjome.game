using System.Collections.Generic;
using System.Linq;

namespace memamjome.gamesys.Series
{
    public class SeriesGeneratorFacade
    {
        private readonly SeriesGeneratorBuilder _seriesGeneratorBuilder = new SeriesGeneratorBuilder();

        public IEnumerable<double> Generate(double x, double y, int count)
        {
            var generator = _seriesGeneratorBuilder.GetSeriesGenerator();

            var series = generator.Generate(x, y).Take(count);

            return series.OrderBy(d => d);
        }
    }
}
