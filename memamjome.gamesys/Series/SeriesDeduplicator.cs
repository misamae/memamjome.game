using System;
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

        public IEnumerable<double> Generate(SeriesPayLoad payload)
        {
            var set = new HashSet<double>();
            var enumerator = _decorated.Generate(payload).GetEnumerator();

            while (enumerator.MoveNext())
            {
                var currentValue = enumerator.Current;

                if (!set.Contains(currentValue))
                {
                    set.Add(currentValue);
                    yield return currentValue;
                }
            }
        }
    }
}
