using Tyuiu.SeledkovNP.Sprint3.Task0.V6.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine( "Спринт #3 | Выполнила: Селедков Н. П. | Смартю-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();

        }
    }
}
