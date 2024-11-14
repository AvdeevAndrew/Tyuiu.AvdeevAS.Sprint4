using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint4.Task3.V30.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        int[,] array =
        {
            { 2, 4, 3, 5, 1 },
            { 6, 6, 1, 2, 6 },
            { 3, 3, 2, 1, 5 },
            { 6, 4, 1, 3, 3 },
            { 5, 1, 1, 6, 4 }
        };

        int expectedMax = 5;

        int result = ds.Calculate(array);

        Assert.AreEqual(expectedMax, result);
    }
}
