using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();

                    Console.Write("Введите число");
                    double num = double.Parse(Console.ReadLine());

                    if (num >= 0)
                    {
                        num += 5;
                    }
                    else
                    {
                        num -= 5;
                    }
                    Console.WriteLine($"Итог: {num}");
                    }
                    break;

                case ConsoleKey.D2:
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        double num3 = double.Parse(Console.ReadLine());

                        if (num1 >= num2 && num1 >= num3)
                        {
                            Console.WriteLine($"Максимальное число: {num1}");
                        }
                        else if(num2 >= num1 && num2 >= num3)
                        {
                            Console.WriteLine($"Максимально число{num2}");
                        }
                        else
                        {
                            Console.WriteLine($"Максимальное число: {num3}");
                        }
                    }
                    break;

                case ConsoleKey.D3:
                    {
                        Console.Write("Введите первое число: ");
                        double number1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double number2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        double number3 = double.Parse(Console.ReadLine());

                        double sum = 0;
                        if (number1 > 0)
                        {
                            sum += number1;
                        }
                        if(number2 > 0)
                        {
                            sum += number2;
                        }
                        if(number3 > 0)
                        {
                            sum += number3;
                        }
                        Console.WriteLine($"Сумма положительных чисел: {sum}");
                    }
                    break;

                case ConsoleKey.D4:
                    {
                        Console.WriteLine("Введите число х: ");
                        double x = double.Parse(Console.ReadLine());

                        if(x > 10)
                        {
                            x *= 2;
                        }
                    }
                    break;

                case ConsoleKey.D5:
                    {

                    }
                    break;
            }
        }
    }
}
