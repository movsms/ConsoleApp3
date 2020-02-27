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
            int a = int.Parse(a_str);
            int b = int.Parse(b_str);
            int c = int.Parse(c_str);
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
