using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint4.Task2.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        int[] array = { 4, 5, 6, 9, 8, 7, 6, 3, 9, 4, 8 };
        int expectedProduct = 4 * 6 * 8 * 6 * 4 * 8;

        int result = ds.Calculate(array);

        Assert.AreEqual(expectedProduct, result);
    }
}
