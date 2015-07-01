using System;
using System.Collections.Generic;

namespace memamjome.gamesys.Series
{
    interface ISeriesGenerator
    {
        IEnumerable<double> Generate(SeriesPayLoad payload);
    }
}
