using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RedikultsevaAA.Sprint2.TaskReview.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x*x + y * y <= 4) && (x * x + y * y >= 1) && (y >= 0))
                return true;
            else
                return false;
        }
    }
}
