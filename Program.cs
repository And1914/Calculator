using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double g))
            {
                Console.WriteLine("Некорректное число.");
                return;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double r))
            {
                Console.WriteLine("Некорректное число.");
                return;
            }

            Console.Write("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine()?.Trim() ?? "";

            // Проверка на пустой ввод операции
            if (string.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Операция не введена.");
                return;
            }

            double result;

            switch (operation)
            {
                case "+":
                    result = g + r;
                    break;
                case "-":
                    result = g - r;
                    break;
                case "*":
                    result = g * r;
                    break;
                case "/":
                    if (r == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя.");
                        return;
                    }
                    result = g / r;
                    break;
                default:
                    Console.WriteLine("Неизвестная операция.");
                    return;
            }

            // Вывод результата вычислений
            Console.WriteLine($"Результат: {result}");
        }
    }
}
