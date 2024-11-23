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

            CreditCard creditCard = new CreditCard(2, "John Doe", 123, "12/12/2022");
            Console.WriteLine(creditCard.ToString());
        }
    }
}
