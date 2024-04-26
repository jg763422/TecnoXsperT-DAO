using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Person:Base
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string FirtsNmae { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CiNit {  get; set; }
        public char Sex { get; set; }
        public string Extension { get; set; }
        public Person(string name, string firtsNmae, string secondName, DateTime birthDate, string ciNit, char sex, string extension, byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(Status, RegisterDate, RegisterUpDate, UserID)
        {
            Name = name;
            FirtsNmae = firtsNmae;
            SecondName = secondName;
            BirthDate = birthDate;
            CiNit = ciNit;
            Sex = sex;
            Extension = extension;
        }
    }
}
