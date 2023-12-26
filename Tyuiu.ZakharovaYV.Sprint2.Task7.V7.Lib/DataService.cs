using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakharovaYV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            double r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (r <= 1 && y > 0 && !(r <= 0.3 && x >= 0))
            {
                res = true;
            }
            else 
            {
                res = false;
            }
            return res;
        }
    }
}
//(((Math.Pow(x, 2) + Math.Pow(y - 1, 2)) <= 1)
//(x >= 0.3 && y >= 0.3 && x >= -1 && x <= 1)))