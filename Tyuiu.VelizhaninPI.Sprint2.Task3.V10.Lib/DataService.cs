using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VelizhaninPI.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0) y = Math.Round(x - Math.Pow(((x + 15) / (x - 4)), x), 3);
            else if (x == 0) y = Math.Round((Math.Pow(x, 2) + Math.Pow(Math.Cos(x), 2) -3 )/((Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 2)), 3);
            else if ((x > -14) && (x < 0)) y = Math.Round(Math.Pow(5 + (1/Math.Pow(x, 2)), x), 3);
            else if (x < -14) y = Math.Round((x + 10 * x - (1/x)), 3);

            return y;
        }
    }
}
