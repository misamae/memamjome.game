using System.Collections.Generic;

namespace memamjome.gamesys.Series
{
    interface ISeriesGenerator
    {
        IEnumerable<double> Generate(double x, double y);
    }
}
