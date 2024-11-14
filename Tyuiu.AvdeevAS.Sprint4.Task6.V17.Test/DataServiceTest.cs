using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AvdeevAS.Sprint4.Task6.V17.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
        int expectedCount = 2; 

        int result = ds.Calculate(array);

        Assert.AreEqual(expectedCount, result);
    }
}
