using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0;
            TriangleClass obj = new TriangleClass();
            Console.WriteLine(" Enter side a:");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter side b:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter side c:");
            c = Double.Parse(Console.ReadLine());
            if (obj.checkSides(a, b, c))
            {
                Console.WriteLine("Triangle with sides " + a + ", " + b + ", " + c + " exist!");
            }
            else
                Console.WriteLine("Triangle with sides " + a + ", " + b + ", " + c + " doesn't exist!");
        }
    }
}
