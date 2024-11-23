using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class IsBinary
    {
        public static bool IsBin(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
