using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Category:Base
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category(string name, string description, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Name = name;
            Description = description;
        }
    }
}
