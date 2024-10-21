using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {

            double SumSeries = 1;
            int k;
            for (k = startValue; k <= stopValue; k++)
            {
                SumSeries = SumSeries * (1 / Math.Pow((Math.Cos(5) + 1), 2));
            }
            return Math.Round(SumSeries, 3);
        }

    }
    
}
