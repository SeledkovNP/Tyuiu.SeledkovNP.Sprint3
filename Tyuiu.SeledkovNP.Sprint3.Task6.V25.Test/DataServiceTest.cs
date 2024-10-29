using Tyuiu.SeledkovNP.Sprint3.Task6.V25.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            double res = 0;

             res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(5, res);
           
        }
    }
}