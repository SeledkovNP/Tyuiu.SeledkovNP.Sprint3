using Newtonsoft.Json.Linq;
using Tyuiu.SeledkovNP.Sprint3.Task3.V30.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataService
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new();
            string van = "fyyklbtyn ygrc vfyyyyh";
            char to = '0';
            var res = ds.GetMaxCharCount(van, to);
            Assert.AreEqual(4, res);

        }
    }
}