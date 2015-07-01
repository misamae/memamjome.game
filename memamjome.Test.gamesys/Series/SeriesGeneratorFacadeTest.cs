using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using memamjome.gamesys.Exceptions;
using memamjome.gamesys.Series;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace memamjome.Test.gamesys.Series
{
    [TestClass]
    public class SeriesGeneratorFacadeTest
    {
        private static readonly SeriesPayLoad TestPayLoad = new SeriesPayLoad(1.0, 5062.5);

        [TestMethod]
        public void Generate_Lenght0_ShouldGenerateEmptySeries()
        {
            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(TestPayLoad, 0);

            DiagnoseSeries(series);
            Assert.IsNotNull(series);
            Assert.IsFalse(series.Any());
        }

        [TestMethod]
        public void Generate_Length5_ShouldGenerateFiveNumbers()
        {
            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(TestPayLoad, 5);

            DiagnoseSeries(series);
            Assert.IsNotNull(series);
            Assert.AreEqual(5, series.Count());
        }

        [TestMethod]
        public void Generate_Length5_FirstNumberShouldBeSetToFirstNumberRounded()
        {
            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(TestPayLoad, 5).ToList();

            var firstNumber = series.ElementAt(0);

            Assert.AreEqual(1.5, firstNumber);
        }

        [TestMethod]
        public void Generate_Length5_ShouldGenerateNumbersRounded()
        {
            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(TestPayLoad, 5).ToList();

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
            var payload = new SeriesPayLoad(-60.49590136, 1250.0);

            var generator = new SeriesGeneratorFacade();

            generator.Generate(payload, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsSecondRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            var payload = new SeriesPayLoad(-58.80972058, 1250.0);

            var generator = new SeriesGeneratorFacade();

            generator.Generate(payload, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsThirdRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            var payload = new SeriesPayLoad(0.49590136, 1250.0);

            var generator = new SeriesGeneratorFacade();

            generator.Generate(payload, 5).ToList();
        }

        /// <summary>
        /// Please Refer to assumptions in README.md for explanation
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidSeriesException))]
        public void Generate_XIsForthRootOfFirstNumberGenerator_ThrowsInvalidOperationException()
        {
            var payload = new SeriesPayLoad(-1.190279418, 1250.0);

            var generator = new SeriesGeneratorFacade();

            generator.Generate(payload, 5).ToList();
        }

        [TestMethod]
        public void Generate_XGeneratesLessThanOneForFirstNumber_SeriesShouldBeSorted()
        {
            var payload = new SeriesPayLoad(-59, 1250.0);

            var generator = new SeriesGeneratorFacade();

            var series = generator.Generate(payload, 5).ToList();

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
