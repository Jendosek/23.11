using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Entities
{
    internal class Rebuilder
    {
        public static void Rebuild(string line)
        {
            int[] numbers = new int[9];
            int count = 0;

            Console.WriteLine("Введіть 9 чисел від 0 до 9:");
            while (count < 9)
            {
                try
                {
                    Console.Write($"Введіть число {count + 1}: ");
                    string input = Console.ReadLine();

                    int number = int.Parse(input);

                    if (number < int.MinValue || number > int.MaxValue)
                    {
                        throw new OverflowException();
                    }

                    numbers[count] = number;
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: введене значення не є числом. Спробуйте ще раз.");
                }
            }

            Console.WriteLine("Введені числа:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
