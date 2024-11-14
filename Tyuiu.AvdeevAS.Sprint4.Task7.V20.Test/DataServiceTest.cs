using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint4.Task7.V20.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        string value = "357951248632587";
        int expectedProduct = 2 * 4 * 8 * 6 * 2 * 8;

        int result = ds.Calculate(5, 3, value);

        Assert.AreEqual(expectedProduct, result);
    }
}
