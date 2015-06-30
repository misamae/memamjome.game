using System.Collections.Generic;

namespace memamjome.gamesys.Series
{
    class SeriesDeduplicator : ISeriesGenerator
    {
        private readonly ISeriesGenerator _decorated;

        public SeriesDeduplicator(ISeriesGenerator decorated)
        {
            _decorated = decorated;
        }

        public IEnumerable<double> Generate(double x, double y)
        {
            var set = new HashSet<double>();
            var enumerator = _decorated.Generate(x, y).GetEnumerator();

            while(enumerator.MoveNext())
            {
                var currentValue = enumerator.Current;

                if(!set.Contains(currentValue))
                {
                    set.Add(currentValue);
                    yield return currentValue;
                }
            }

        }
    }
}
