using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Delivery:Base
    {
        public short Id { get; set; }
        public string NameCompany { get; set; }
        public string Phone {  get; set; }
        public string Direccion { get; set; }
        public Delivery(string nameCompany, string phone, string direccion, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            NameCompany = nameCompany;
            Phone = phone;
            Direccion = direccion;
        }
    }
}
