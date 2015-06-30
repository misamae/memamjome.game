using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memamjome.gamesys.Exceptions;
using memamjome.gamesys.Series;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace memamjome.Test.gamesys.Series
{
    [TestClass]
    public class SeriesGeneratorTest
    {
        [TestMethod]
        public void Generate_Lenght0_ShouldGenerateEmptySeries()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 0);

            DiagnoseSeries(series);
            Assert.IsNotNull(series);
            Assert.IsFalse(series.Any());
        }

        [TestMethod]
        public void Generate_Length5_ShouldGenerateFiveNumbers()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5);

            DiagnoseSeries(series);
            Assert.IsNotNull(series);
            Assert.AreEqual(5, series.Count());
        }

        [TestMethod]
        public void Generate_Length5_FirstNumberShouldBeSetToFirstNumberRounded()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();

            var firstNumber = series.ElementAt(0);

            Assert.AreEqual(1.5, firstNumber);
        }

        [TestMethod]
        public void Generate_Length5_ShouldGenerateNumbersRounded()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();

            DiagnoseSeries(series);
            Assert.AreEqual(1.5, series[0]);
            Assert.AreEqual(4, series[1]);
            Assert.AreEqual(6.5, series[2]);
            Assert.AreEqual(10.75, series[3]);
            Assert.AreEqual(17.25, series[4]);
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsFirstRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            const double x = -60.49590136;
            const double y = 1250.0;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsSecondRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            const double x = -58.80972058;
            const double y = 1250.0;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsThirdRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            const double x = 0.495901364;
            const double y = 1250.0;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsForthRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            const double x = -1.190279418;
            const double y = 1250.0;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();
        }

        [TestMethod]
        public void Generate_XGeneratesLessThanOneForFirstNumber_SeriesShouldBeSorted()
        {
            const double x = -59;
            const double y = 1250.0;

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(x, y, 5).ToList();

            DiagnoseSeries(series);
            Assert.IsTrue(series[0] < series[1]);
        }

        private static void DiagnoseSeries(IEnumerable<double> series)
        {
            foreach (var d in series)
            {
                Debug.WriteLine(d);
            }
        }
    }
}
