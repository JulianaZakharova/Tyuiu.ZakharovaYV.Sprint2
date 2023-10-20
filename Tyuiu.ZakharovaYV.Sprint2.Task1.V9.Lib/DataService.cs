using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений,
//которая вернет логическую последовательность(массив): (False, False, True, False, True, False), при a = 15, b = 335, c = 174, d = 478

//Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом.
//Интерфейс консольного приложения оформить по шаблону. 



namespace Tyuiu.ZakharovaYV.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d);    //f + f = f
            res[1] = (a + 3 > b) & (c + 300 < d); //f+f=f
            res[2] = (a > b) || (c < d); //f+t=t
            res[3] = (a+2>b) && (c < d); //f + t = f
            res[4] = (!res[0]); //t
            res[5] = (a > b) ^ (c > d); //f+f =f

            return res;
        }
    }
}
