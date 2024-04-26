using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Base
    {
        public byte Status { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime RegisterUpDate { get; set; }
        public short UserID { get; set; } //Smallint
        public Base(byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
        {
            this.Status = Status;
            this.RegisterDate = RegisterDate;
            this.RegisterUpDate = RegisterUpDate;
            this.UserID = UserID;
        }
    }
}
