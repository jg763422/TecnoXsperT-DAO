using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Discount:Base
    {
        public byte Id { get; set; }
        public string Denomination { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public Discount(string denomination, string description, double amount, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Denomination = denomination;
            Description = description;
            Amount = amount;
        }
    }
}
