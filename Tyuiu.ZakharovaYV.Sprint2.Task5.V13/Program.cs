using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца := " );
            int namMouth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введенно неверное значение!Эж

            }
            else 
            {
                res = "Это месяц: " + ds.FindMonthName(namMouth);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
