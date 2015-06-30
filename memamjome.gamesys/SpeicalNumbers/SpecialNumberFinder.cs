﻿using System.Linq;
using memamjome.gamesys.Series;

namespace memamjome.gamesys.SpeicalNumbers
{
    public class SpecialNumberFinder
    {
        private readonly SeriesGeneratorFacade _generator;

        public SpecialNumberFinder(SeriesGeneratorFacade generator)
        {
            _generator = generator;
        }

        public double GetNthLargetNumber(double x, double y, int count, int index)
        {
            var series = _generator.Generate(x, y, count).ToList();

            return index == 0
                ? series[count - 1]
                : series[count - index];
        }
    }
}