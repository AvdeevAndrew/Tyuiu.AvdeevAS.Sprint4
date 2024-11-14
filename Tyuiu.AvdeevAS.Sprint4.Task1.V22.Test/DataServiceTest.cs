using Tyuiu.AvdeevAS.Sprint4.Task1.V22.Lib;
namespace Tyuiu.AvdeevAS.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            int expectedProduct = 5 * 3 * 9 * 9 * 9 * 3 * 9;

            int result = ds.Calculate(array);

            Assert.AreEqual(expectedProduct, result);
        }
    }
}