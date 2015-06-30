using System.Diagnostics;
using memamjome.gamesys.Series;
using memamjome.gamesys.SpeicalNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace memamjome.Test.gamesys.SpeicalNumbers
{
    [TestClass]
    public class SpecialNumberTests
    {
        private static double ApproximateNumberConstant = 1000;

        [TestMethod]
        public void Get3rdLargetNumber()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(x, y, 5, 3);

            Assert.AreEqual(6.5, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetLastLargetNumber()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(x, y, 5, 5);

            Assert.AreEqual(1.5, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetLargetNumber()
        {
            const double x = 1.0;
            const double y = 5062.5;

            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(x, y, 5, 0);

            Assert.AreEqual(17.25, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetClosestSpecialNumber()
        {
            const double x = 1.0;
            const double y = 5062.5;

            int z = 160;

            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetClosetSpecialNumber(x, y, 5, 160);

            Assert.AreEqual(6.5, specialNumber);
        }
    }
}
