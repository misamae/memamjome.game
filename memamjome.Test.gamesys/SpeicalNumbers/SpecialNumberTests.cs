using System.Diagnostics;
using memamjome.gamesys.Series;
using memamjome.gamesys.SpeicalNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace memamjome.Test.gamesys.SpeicalNumbers
{
    [TestClass]
    public class SpecialNumberTests
    {
        private const double ApproximateNumberConstant = 1000;
        private static readonly SeriesPayLoad TestPayLoad = new SeriesPayLoad(1.0, 5062.5);

        [TestMethod]
        public void Get3RdLargetNumber()
        {
            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(TestPayLoad, 5, 3);

            Assert.AreEqual(6.5, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetLastLargetNumber()
        {
            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(TestPayLoad, 5, 5);

            Assert.AreEqual(1.5, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetLargetNumber()
        {
            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetNthLargetNumber(TestPayLoad, 5, 0);

            Assert.AreEqual(17.25, specialNumber);
            Debug.WriteLine(specialNumber);
        }

        [TestMethod]
        public void GetClosestSpecialNumber()
        {
            const int z = 160;

            var finder = new SpecialNumberFinder(new SeriesGeneratorFacade(), ApproximateNumberConstant);

            var specialNumber = finder.GetClosetSpecialNumber(TestPayLoad, 5, z);

            Assert.AreEqual(6.5, specialNumber);
        }
    }
}
