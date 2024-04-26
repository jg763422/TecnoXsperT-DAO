using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Branch:Base
    {
        public byte Id { get; set; }
        public string Denomination { get; set; }
        public string GPS { get; set; }
        public Branch(string denomination, string gPS,  byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Denomination = denomination;
            GPS = gPS;
        }
    }
}
