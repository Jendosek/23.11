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

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value.Length > 9)
                {
                     throw new Exception("Invalid ID");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value.Length > 9)
                {
                    Console.WriteLine("Invalid Date");
                }
                else
                {
                    _date = value;
                }
            }
        }

        public ForeignPassport()
        {
            Id = "000000000";
            Name = "NoName";
            Date = "00.00.0000";
        }
        public ForeignPassport(string id, string name, string date)
        {
            Id = id;
            Name = name;
            Date = date;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Date: {Date}";
        }


    }
}
