using Tyuiu.SeledkovNP.Sprint3.Task7.V11.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("Спринт #3 | Выполнила: Селедков Н. П. | Смартю-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

               //                  sin(x)
              //  F(x) = cos(x) + -------  - 4x
             //                    2-2x
            // F(x) от -5 до 5
           //     Шаг 1 целое число
          //       Деление на 0, при деление занести в масив.      (3 знака после запитой)


            // Определяем диапазон и шаг
           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            // Получение массива значений функции
            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Вывод таблицы значений
            Console.WriteLine(" Таблица значений функции F(x) = cos(x) + sin(x) / (2 - 2x) - 4 ");
            Console.WriteLine(" x   |   F(x) ");
            Console.WriteLine("--------------------");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{i + startValue,3} | {res[i],7:F2}");
            }
            Console.ReadKey();
        }

    }
}
