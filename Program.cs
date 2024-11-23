using ConsoleApp1.Entites;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть математичний вираз, що складається з цілих чисел та операторів * (наприклад, 3*2*1*4):");
            string input = Console.ReadLine();

            try
            {
                if (IsValid.IsInputValid(input))
                {
                    Console.WriteLine($"Результат обчислення виразу {input} дорівнює {Calculator.CalculateExpression(input)}");
                }
                else
                {
                    Console.WriteLine("Ви ввели некоректний вираз. Спробуйте ще раз.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Під час обчислення виразу виникла помилка: {ex.Message}");
            }
        }
    }
}