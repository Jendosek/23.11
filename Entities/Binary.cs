using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Binary
    {
        public static int ConvertToBinary(string line)
        {
            return Convert.ToInt32(line, 2);
        }
    }
}
