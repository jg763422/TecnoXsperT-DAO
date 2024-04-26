using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Job:Base
    {
        public byte Id { get; set; } //tinyint
        public string Name { get; set; }
        public string Description { get; set; }
        public double BaseSalary { get; set; }

        public Job(string name, string description, double baseSalary, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Name = name;
            Description = description;
            BaseSalary = baseSalary;
        }
    }
}
