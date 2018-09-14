using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.WriteLine("Third commit");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|Operators: +, -, *, /|");
            Console.WriteLine("| c - previous result |");
            Console.WriteLine("-----------------------");

            //data
            string s_a, s_b;
            double f_a = 0;
            double  f_b = 0;
            double  f_c = 0;
            string operation=null;


            for (;;)
            {
                bool stat1 = false, stat2 = false, stat3 = false;

                #region number a

                while (stat1 == false)
                {
                    Console.Write("Enter a:");
                    s_a = Console.ReadLine();

                    if (s_a == "c")
                    {
                        f_a = f_c;
                        stat1 = true;
                    }
                    else
                    {
                        try
                        {
                            f_a = Convert.ToDouble(s_a);
                            stat1 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Enter number!");
                            stat1 = false;
                        }
                    }
                }
                #endregion

                #region operator

                while (stat2 == false)
                {
                    Console.Write("Enter an operator: ");
                    operation = Console.ReadLine();

                    if (operation != null)
                    {
                        if (operation == "+")
                        {
                            stat2 = true;
                        }
                        else if (operation == "-")
                        {
                            stat2 = true;
                        }
                        else if (operation == "*")
                        {
                            stat2 = true;
                        }
                        else if (operation == "/")
                        {
                            stat2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Error Operator!");
                            stat2 = false;
                        }
                    }
                }
                #endregion

                #region number b
                while (stat3 == false)
                {
                    Console.Write("Enter b:");
                    s_b = Console.ReadLine();

                    if (s_b == "c")
                    {
                        f_b = f_c;
                        stat3 = true;
                    }
                    else
                    {
                        try
                        {
                            f_b = Convert.ToDouble(s_b);
                            stat3 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Enter number!");
                            stat3 = false;
                        }
                    }
                }
                #endregion



                if (operation != null)
                {
                    if (operation == "+")
                    {
                        f_c = f_a + f_b;
                        stat2 = true;
                    }
                    else if (operation == "-")
                    {
                        f_c = f_a - f_b;
                        stat2 = true;
                    }
                    else if (operation == "*")
                    {
                        f_c = f_a * f_b;
                        stat2 = true;
                    }
                    else if (operation == "/")
                    {
                        f_c = f_a / f_b;
                        stat2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Error Operator!");
                        stat2 = false;
                    }
                }

                try
                {
                    Console.WriteLine(f_a + operation + f_b + "=" + f_c);
                }
                catch { Console.WriteLine("Error!"); }
            }
        
            }


        
    }
}
