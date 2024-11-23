using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class ForeignPassport
    {
        private string _id { get; set; }
        public string Name { get; set; }
        private string _date { get; set; }

        public Id
        {
            get
            {
                return new Id(_id);
            }
            set
            {
                _id = value.Value;
            }
        }


    }
}
