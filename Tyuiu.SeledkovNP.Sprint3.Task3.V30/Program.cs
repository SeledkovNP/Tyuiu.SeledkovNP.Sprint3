using Tyuiu.SeledkovNP.Sprint3.Task3.V30.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("Спринт #3 | Выполнила: Селедков Н. П. | Смартю-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
            Console.WriteLine("*  находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh      *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            //  fyyklbtyn ygrc vfyyyyh

            string value = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';

            Console.WriteLine("* Исходная строка - " + value);
            Console.WriteLine("* Исходный символ - " + chr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимальное повторение символа " + chr + ": " + ds.GetMaxCharCount(value, chr));

            Console.ReadKey();


        }
    }
}
