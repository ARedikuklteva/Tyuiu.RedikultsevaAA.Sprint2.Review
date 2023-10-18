using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint2.TaskReview.V15.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint2.TaskReview.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт-Review #2 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Спринт-Review #2                                                     *");
            Console.WriteLine("* Вариант #15                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные              *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами X,Y *");
            Console.WriteLine("* в заштрихованной области.                                                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
