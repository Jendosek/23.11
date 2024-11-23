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

            ForeignPassport passport = new ForeignPassport("12345678", "Zenya", "20.11");
            Console.WriteLine(passport.ToString());
        }
    }
}
