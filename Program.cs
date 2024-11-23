using ConsoleApp1.Entities;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = new int[5];
            int count = 0;

            while (count < 5)
            {
                try
                {
                    Console.Write($"Введіть число {count + 1}: ");
                    string input = Console.ReadLine();
                    if (IsBinary.IsBin(input))
                    {
                        numbers[count] = Binary.ConvertToBinary(input);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели не двійкове число");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }




        }

    }
}
