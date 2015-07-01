using System.Diagnostics;

namespace memamjome.gamesys.Series
{
    [DebuggerDisplay("x:{X}, y:{Y}")]
    public class SeriesPayLoad
    {
        public SeriesPayLoad(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
    }
}