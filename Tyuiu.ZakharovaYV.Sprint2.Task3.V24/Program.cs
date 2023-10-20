using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint2.Task3.V24.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("ВВедите значение переменной Х = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции =" + res);

            Console.ReadKey();
        }
    }
}
