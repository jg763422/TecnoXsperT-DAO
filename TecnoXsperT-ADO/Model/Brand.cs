using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Brand:Base
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo {  get; set; }
        public string Phone { get; set; }
        public byte Sponsor {  get; set; }
        public Brand(string name, string description, string photo, string phone, byte sponsor, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Name = name;
            Description = description;
            Photo = photo;
            Phone = phone;
            Sponsor = sponsor;
        }
    }
}
