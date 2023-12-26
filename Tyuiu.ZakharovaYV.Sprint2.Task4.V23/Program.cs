﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint2.Task4.V23.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Захарова Ю. В. | ПКТБ 23 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание # 4                                                             *");
            Console.WriteLine("* Вариант # 23                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна   | ПКТБ-23-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной Х = " );
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной Y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Значение функции  = " + res);

            Console.ReadKey();
        }
    }
}
