using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memamjome.gamesys.Series
{
    public interface ISeriesGenerator
    {
        IEnumerable<double> Generate(double x, double y);
    }
}
