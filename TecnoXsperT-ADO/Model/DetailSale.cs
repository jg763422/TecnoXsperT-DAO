using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class DetailSale:Base
    {
        public short ProductID { get; set; }
        public int SaleID { get; set; }
        public double UnitPrice { get; set; }
        public byte Quantity { get; set; }
        public byte DiscountID { get; set; }
        public DetailSale(short productID, int saleID, double unitPrice, byte quantity, byte discountID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            ProductID = productID;
            SaleID = saleID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            DiscountID = discountID;
        }
        public DetailSale(short productID, int saleID, double unitPrice, byte quantity, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            ProductID = productID;
            SaleID = saleID;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
