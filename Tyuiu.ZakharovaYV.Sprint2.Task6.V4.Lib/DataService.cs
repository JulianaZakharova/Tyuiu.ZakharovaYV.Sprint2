using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakharovaYV.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {

            int FindDayName = (k - 1) % 7;

            switch (FindDayName)
            {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                            return "Понедельник";
                    case 2:
                    case 9:
                    case 16:
                    case 23:
                    case 30:
                             return "Вторник";
                    case 3:
                    case 10:
                    case 17:
                    case 24:
                    case 31:
                             return "Среда";
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                              return "Четверг";
                    case 5:
                    case 12:
                    case 19:
                    case 26:
                              return "Пятница";
                    case 6:
                    case 13:
                    case 20:
                    case 27:
                              return "Суббота";
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                              return "Воскресенье";
                    default: throw new ArgumentException($"День должен быть от 1 до 365. Значение {k} ");
            }
           
            
        }
    }
}
