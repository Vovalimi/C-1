using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Програма для розв'язання квадратного рівняння ax^2 + bx + c = 0");

        // Введення коефіцієнтів
        Console.WriteLine("Введіть a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть c:");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Рівняння: {a}x^2 + {b}x + {c} = 0");

        // Обчислення дискримінанту
        double D = b * b - 4 * a * c;

        // Перевірка дискримінанту
        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"Розв'язки: x1 = {x1}, x2 = {x2}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Розв'язок: x = {x}");
        }
        else
        {
            Console.WriteLine("Рівняння не має дійсних коренів");
        }

        Console.WriteLine("Виконав:Колісниченко Володимир");
        Console.WriteLine("Група: кн-1-21");
    }
}