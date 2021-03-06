﻿using System;
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

        private static bool Compare(double x, double y)
        {
            return Math.Abs(x - y) < Common.MagicNumbers.Double2DigitCompareThreshold;
        }

        public IEnumerable<double> Generate(SeriesPayLoad payload)
        {
            if (Compare(payload.X, Common.MagicNumbers.X0Root01)
                || Compare(payload.X, Common.MagicNumbers.X0Root02)
                || Compare(payload.X, Common.MagicNumbers.X0Root03)
                || Compare(payload.X, Common.MagicNumbers.X0Root04))
            {
                throw new InvalidSeriesException();
            }

            return _decorated.Generate(payload);
        }
    }
}
