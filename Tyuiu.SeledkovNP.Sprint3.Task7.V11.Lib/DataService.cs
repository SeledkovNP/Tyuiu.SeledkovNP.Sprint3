using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {

        public double[] GetMassFunction(int startValue, int stopValue)
        {


            // Метод для получения массива значений функции
           
                int length = stopValue - startValue + 1;
                double[] res = new double[length];

                for (int i = startValue; i <= stopValue; i++)
                {
                    res[i - startValue] = CalculateFunction(i);
                }

                return res;

            

        }


        static double CalculateFunction(double x)
            {
                try
                {
                    return Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x;
                }
                catch (DivideByZeroException)
                {
                    return 0; // Возвращаем 0 при делении на ноль
                }
            }

        
    }
}
