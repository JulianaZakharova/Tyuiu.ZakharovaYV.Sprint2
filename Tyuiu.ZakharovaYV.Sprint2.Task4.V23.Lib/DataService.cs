using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakharovaYV.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V23
    {
        public double Calculate(double x, double y)
        {
            double z = x > y ? (y / x + 3) : ((y - 1) / (x + 2));
            return Math.Round(z, 3);
        }
    }
}
