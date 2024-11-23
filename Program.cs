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

            Console.WriteLine("Enter a number in words: ");
            var word = Console.ReadLine();

            int num = ConverFromWordToNumber.Convert(word);
            Console.WriteLine(num);
        }
    }
}
