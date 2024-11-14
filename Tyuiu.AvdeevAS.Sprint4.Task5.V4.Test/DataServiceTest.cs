using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint4.Task5.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        int[,] matrix =
        {
            { -1, 2, 3, -4, 5 },
            { 0, 6, -3, 2, -1 },
            { -4, 4, -2, 1, 3 },
            { -1, -2, 5, 6, 0 },
            { 1, 3, -4, -3, 2 }
        };

        int expectedCount = 13;

        int result = ds.Calculate(matrix);

        Assert.AreEqual(expectedCount, result);
    }
}
