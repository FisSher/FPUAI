using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNac { get; set; }
        public PaqueteSilver PaqueteS { get; set; }
        public PaquetePremium PaqueteP { get; set; }
        

        public override string ToString()
        {
            return CodCliente + " " + Nombre + " " + Apellido + " " + DNI + " " + Mail + " " + FechaNac.ToString();
        }

        public Cliente() { }
        //Esto es para facilitar carga dummy
        public Cliente(int cod, string nombre, string apellido, int dni, string mail)
        {
            CodCliente = cod;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Mail = mail;
            FechaNac = DateTime.Now;
        }
    }
}
