using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SeledkovNP.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {

            double product = 1;              // Инициализация произведения
            bool hasValues = false;         // Проверка на наличие значений

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)                 // Пропускаем значение при x = 0
                {
                    continue;
                }

                double y = (Math.Cos(x) + x) / x + 0.25;      // Вычисление функции
                product *= y;                                // Умножение на текущее значение y
                hasValues = true;                           // Обозначаем, что есть значения для произведения
            }

            return Math.Round(product, 3);                      // значения до 3 после запитой

        }
    }
}
