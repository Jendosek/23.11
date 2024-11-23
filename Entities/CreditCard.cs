using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class CreditCard
    {
        private int _id { get; set; }
        private string _name { get; set; }
        public int Cvc { get; set; }
        public string ExpiryDate { get; set; }

        public int Id
        {
            get => _id;
            set
            {
                if (value < 1 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Id must be between 1 and 8");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public CreditCard()
        {
            _id = 0;
            _name = "Unknown";
            Cvc = 0;
            ExpiryDate = "00/00/0000";
        }

        public CreditCard(int id, string name, int cvc, string expiryDate)
        {
            Id = id;
            Name = name;
            Cvc = cvc;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Cvc: {Cvc}, ExpiryDate: {ExpiryDate}";
        }
    }
}
