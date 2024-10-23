using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {

            double multSeries = 1;

            do
            {
                multSeries = multSeries * ((Math.Pow(value, 3) * startValue) + 2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(multSeries, 3);

        }
    }
}
