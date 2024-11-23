using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Convertor
    {
        public void SetAndDispay(int num, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Двійкова: {Convert.ToString(num, 2)}");
                    break;
                case 2:
                    Console.WriteLine($"Вісімкова: {Convert.ToString(num, 8)}");
                    break;
                case 3:
                    Console.WriteLine($"Шістнадцяткова: {Convert.ToString(num, 16)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
