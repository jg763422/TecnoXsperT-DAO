using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Product:Base
    {
        public short Id { get; set; }
        public string Denomination { get; set; }
        public short Stock { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string Photo {  get; set; }
        public string Code { get; set; }
        public double Guarantee { get; set; }
        public byte CategoryID { get; set; }
        public short BrandID { get; set; }
        public Product(string denomination, short stock, double unitPrice, string description, string photo, string code, double guarantee, byte categoryID, short brandID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Denomination = denomination;
            Stock = stock;
            UnitPrice = unitPrice;
            Description = description;
            Photo = photo;
            Code = code;
            Guarantee = guarantee;
            CategoryID = categoryID;
            BrandID = brandID;
        }
    }
}
