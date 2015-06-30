using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memamjome.gamesys.Series
{
    class SeriesGeneratorBuilder
    {
        public ISeriesGenerator GetSeriesGenerator()
        {
            return new SeriesGuard(new SeriesDeduplicator(new SeriesRounderGenerator(new SeriesGenerator())));
        }
    }
}
