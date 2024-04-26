using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Rotation:Base
    {
        public short Id { get; set; } //Smallint
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte JobID { get; set; } //Tinyint
        public short PersonID { get; set; } //Smallint
        public Rotation(DateTime initialDate, DateTime endDate, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID) 
            :base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            this.InitialDate = initialDate;
            this.EndDate = endDate;
        }

        public Rotation(short id, DateTime initialDate, DateTime endDate, byte jobID, short personID, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            :base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Id = id;
            InitialDate = initialDate;
            EndDate = endDate;
            JobID = jobID;
            PersonID = personID;
        }
    }
}
