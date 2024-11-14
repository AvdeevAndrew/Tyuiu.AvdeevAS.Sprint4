using Tyuiu.AvdeevAS.Sprint4.Task0.V16.Lib;

namespace Tyuiu.AvdeevAS.Sprint4.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int expectedProduct = 2 * 6 * 2 * 4 * 4 * 8;

            int result = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(expectedProduct, result);
        }
    }
}