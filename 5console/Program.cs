using System;

namespace _5console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }

        }
        private static double f(double x)
        {
            try
            {
                if (x * x - 2 == 0 || x * x * x - 1 < 0) throw new Exception();
                else return (x + 4) / (x * x - 2) + Math.Sqrt(x * x * x - 1);
            }
            catch
            {
                throw;
            }

        }
    }
}
