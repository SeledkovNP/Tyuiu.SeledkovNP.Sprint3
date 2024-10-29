using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {


            double res = 0;

            for (int i = startValue; i <= stopValue; i++) // Проходим по всем числам в заданном отрезке
            {
                
                for (int j = 1; j < 10; j++) // Проходим по всем возможным делителям меньше 10
                {
                    
                    if (i % j == 0) // Проверяем, является ли j делителем i
                    {
                        res += j; // Если да, добавляем к сумме
                    }
                }
            }
            return (int)res;
        }
    }
}
