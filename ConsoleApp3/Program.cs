using System;
using static System.Math;


namespace ConsoleApp3
{
    class Program
    {
        static Func<double, double> CreateFunction(doble a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите a>");
            String a_str = Console.ReadLine();
            Console.Write("Введите b>");
            String b_str = Console.ReadLine();
            Console.Write("Введите c>");
            String c_str = Console.ReadLine();
            Console.Write("Введите x_min>");
            String x_min_str = Console.ReadLine();
            double a = double.Parse(a_str);
            double b = double.Parse(b_str);
            double c = double.Parse(c_str);
            double x_min = double.Parse(x_min_str);
            double x_max = double.Parse(x_min_str);
        }

        static double ReadValue(string Msg)
        {
            while (true)
            {
                Console.Write(Msg);
                if (double.TryParse(Console.ReadLine(), out double result))
                    return result;
                Console.WriteLine("Ошибка ввода!");
            }
        

            
            //Console.WriteLine("");
        }
    }
}
