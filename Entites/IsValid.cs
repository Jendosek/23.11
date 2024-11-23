using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entites
{
    internal class IsValid
    {
        public static bool IsInputValid(string input)
        {
            return input.Contains('*');
        }
    }
}
