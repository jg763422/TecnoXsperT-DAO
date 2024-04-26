using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Booking:Base
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Total { get; set; }
        public short PersonID { get; set; }
        public short EmployeID { get; set; }
        public short BookingID { get; set; }
        public short DeliberyID { get; set; }
        public Booking(string codo, double total, short personID, short employeID, short bookingID, short deliberyID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Code = codo;
            Total = total;
            PersonID = personID;
            EmployeID = employeID;
            BookingID = bookingID;
            DeliberyID = deliberyID;
        }
        public Booking(string codo, double total, short personID, short employeID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Code = codo;
            Total = total;
            PersonID = personID;
            EmployeID = employeID;
        }
        public Booking(string code, double total, short personID, short employeID, short bookingID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Code = code;
            Total = total;
            PersonID = personID;
            EmployeID = employeID;
            BookingID = bookingID;
        }
    }
}
