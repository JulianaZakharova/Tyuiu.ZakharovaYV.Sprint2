using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakharovaYV.Sprint2.Task3.V24.Lib
{

    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = Math.Round((x * Math.Pow(((10 + (Math.Sin(x + 1))) / x), x)), 3);

            }
            else
            {
                if (x == 0)
                {
                    y = Math.Cos(x) + (12 / Math.Pow(x, 2));
                }
                else
                {
                    if ((-28 < x) && (x < 0))
                    {
                        y = Math.Round((Math.Pow((1 + (1 / Math.Pow(x, 2))), x)),3);
                    }
                    else
                    {
                        if (x < -28)
                        {
                            y = Math.Pow(x, 2) + ((10 * x) - (1 / x));
                        }

                    }
                }
            }
            return y;
        }
    }
}
