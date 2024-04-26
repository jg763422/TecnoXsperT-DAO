using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Model
{
    internal class Employe:Person
    {
        public short Id {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sole { get; set; }
        public char Shift { get; set; }
        public string Imagen { get; set; }
        public string FingerPrint { get; set; }
        public Employe(string username, string password, string sole, char shift, string imagen, string fingerPrint, 
            string name, string firtsNmae, string secondName, DateTime birthDate, string ciNit, char sex, string extension, 
            byte Status, DateTime RegisterDate, DateTime RegisterUpDate, short UserID)
            : base(name, firtsNmae, secondName, birthDate, ciNit, sex, extension, Status, RegisterDate, RegisterUpDate, UserID)
        {
            Username = username;
            Password = password;
            Sole = sole;
            Shift = shift;
            Imagen = imagen;
            FingerPrint = fingerPrint;
        }
    }
}
