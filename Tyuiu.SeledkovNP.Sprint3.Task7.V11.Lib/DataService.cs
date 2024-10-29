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
                // Проверяем деление на ноль перед выполнением операции
                if (2 - 2 * x == 0)
                {
                    return 0.0; // Возвращаем 0.0 при делении на ноль
                }

                double result = Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x;

                // Округляем результат до 2 знаков после запятой
                return Math.Round(result, 2);
            }
            catch (Exception)
            {
                return 0.0; // Возвращаем 0.0 для любых других исключений
            }


        }
        
    }
}
