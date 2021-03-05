using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace calculatorif

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
                {
                Console.Clear();
                double val1, val2;
                char action;
                try
                {
                    Console.WriteLine("Enter value 1");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value 2");
                    val2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter value. Not sumbols!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("What action do you want to perform: +,-,*,/  ?");
                action = char.Parse(Console.ReadLine());
                    if (action == '+')
                {
                    double resultSum = val1 + val2;
                    Console.WriteLine("Sum is " + resultSum);
                }
                    else if (action == '-')
                {
                    double resultRazn = val1 - val2;
                    Console.WriteLine("Raznost' is " + resultRazn);
                }
                    else if (action == '*')
                {
                    double resultCompos = val1 * val2;
                    Console.WriteLine("Composition is " + resultCompos);
                }
                    else if (action == '/')
                {
                    switch (val2)
                    {
                        case 0:
                            Console.WriteLine("Сannot divide by zero. Enter value 2 else!");
                            break;
                        default:
                            double resultQuot = val1 / val2;
                            Console.WriteLine("Quotient is " + resultQuot);
                            break;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Unknown action!!!");
                }
                Console.ReadLine();
            }
            















        }
    }
}
