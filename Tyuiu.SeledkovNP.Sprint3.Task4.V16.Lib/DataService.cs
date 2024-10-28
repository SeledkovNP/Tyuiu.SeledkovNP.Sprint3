using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {

            int x;
            double sp = 0;
            for (x = startValue; x <= stopValue; x++)   // Значения X от -5 до 5
            {
                if (x == 0)        // Если Х = 0, то пропустить
                {
                    continue;
                }
                else                // в ином случии пощитат по формуле
                {
                    sp = sp + ((Math.Cos(x) + x) / x) + 0.25;
                }
            }
            return Math.Round(sp, 3);           // значения всех формул

        }
    }
}
