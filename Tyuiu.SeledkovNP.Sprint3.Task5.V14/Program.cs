using Tyuiu.SeledkovNP.Sprint3.Task5.V14.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            DataService ds = new DataService();
            Console.WriteLine("Спринт #3 | Выполнила: Селедков Н. П. | Смартю-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Название проектов (консольного приложения, библиотеки классов,          *");
            Console.WriteLine("*  тестового модуля) оформить по шаблону в соответствии с вариантом.      *");
            Console.WriteLine("*  Интерфейс консольного приложения оформить по шаблону.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            //   Х=5

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;

            Console.WriteLine($"Переменная X: {x}");           // 5
            Console.WriteLine($"Старт шага первой суммы ряда: {startValue1}");         //начало операции
            Console.WriteLine($"Конец шага первой суммы ряда: {startValue2}");
            Console.WriteLine($"Старт шага второй суммы ряда: {stopValue1}");
            Console.WriteLine($"Конец шага второй суммы ряда: {stopValue2}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Результат = {ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2)}");         // резултат -31.275


            Console.ReadKey();
            
        }
    }
}
