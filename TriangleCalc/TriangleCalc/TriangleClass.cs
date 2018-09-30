using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
   public class TriangleClass
    {



        public bool checkZero(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return true;

            }
            else return false;
        }




        public bool checkSides(double a, double b, double c)
        {
            if (checkZero(a, b, c))
            {
                if (a + b > c && a + c > b && c + b > a)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
    }
}
