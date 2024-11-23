using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entites
{
    internal class Calculator
    {
        public static int CalculateExpression(string input)
        {
            string[] numbers = input.Split('*');
            int result = 1;

            foreach (string number in numbers)
            {
                int value = int.Parse(number);
                result *= value;
            }

            return result;
        }
    }
}
