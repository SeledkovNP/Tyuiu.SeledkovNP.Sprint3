﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)   //-31.275
        {

            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    res += Math.Sin(x) + (2 / startValue2);
                }
            }
            return Math.Round(res, 3);

        }
    }
}
