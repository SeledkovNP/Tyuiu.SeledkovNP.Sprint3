﻿using Tyuiu.SeledkovNP.Sprint3.Task4.V16.Lib;
namespace Tyuiu.SeledkovNP.Sprint3.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("Спринт #3 | Выполнила: Селедков Н. П. | Смартю-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("*  функции y=((cos(x)+x)/x)+0.25                                          *");
            Console.WriteLine("*   При х = 0 пропустить значение Полученные значения перемножать.        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            //  -5 до 5
            //  y=((cos(x)+x)/x)+0.25 
            //  х = 0 пропустить
            //  Полученные значения перемножать  
            //  6.719

            int startValue = Convert.ToInt32(Console.ReadLine());    // Запрашиваю первое значение
            int stopValue = Convert.ToInt32(Console.ReadLine());    //  Запрашиваю второе значения


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine($"Произведение значений функции на отрезке от {startValue} до {stopValue} (с пропуском x=0): "  + ds.Calculate(startValue, stopValue));          //  Ответ = 6.719
               

            Console.ReadKey();

        }
    }
}
