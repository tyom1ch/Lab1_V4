using System;
using System.Globalization;

namespace Lab1_Variant4
{
    // Варіант 4. Дано довжини ребер прямокутного паралелепіпеда a, b та c.
    // Знайти його об'єм та площу поверхні.
    public class Program
    {
        // Об'єм прямокутного паралелепіпеда: V = a * b * c
        static public double Volume(double a, double b, double c)
        {
            return a * b * c;
        }

        // Площа повної поверхні: S = 2 * (ab + bc + ac)
        static public double SurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + b * c + a * c);
        }

        // Зчитування додатного числа з перевіркою коректності введення
        static double ReadPositive(string name)
        {
            while (true)
            {
                Console.Write("Введіть довжину ребра " + name + ": ");
                string s = (Console.ReadLine() ?? "").Replace(',', '.');

                bool ok = double.TryParse(s, NumberStyles.Float,
                                          CultureInfo.InvariantCulture, out double value);
                if (ok && value > 0)
                    return value;

                Console.WriteLine("Помилка: потрібно ввести додатне число. " +
                                  "Спробуйте ще раз.");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №1. Варіант 4");
            Console.WriteLine("Об'єм та площа поверхні прямокутного паралелепіпеда");
            Console.WriteLine();

            double a = ReadPositive("a");
            double b = ReadPositive("b");
            double c = ReadPositive("c");

            double V = Volume(a, b, c);
            double S = SurfaceArea(a, b, c);

            Console.WriteLine();
            Console.WriteLine("Об'єм паралелепіпеда:          V = " + V);
            Console.WriteLine("Площа поверхні паралелепіпеда: S = " + S);
        }
    }
}
