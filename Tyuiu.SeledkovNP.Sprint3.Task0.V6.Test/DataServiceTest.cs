using Tyuiu.SeledkovNP.Sprint3.Task0.V6.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.001;
            Assert.AreEqual(wait, res);

        }
    }
}