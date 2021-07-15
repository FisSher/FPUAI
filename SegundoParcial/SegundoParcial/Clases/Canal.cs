using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Canal:ICloneable
    {
        public int Codigo { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            return Codigo + " " + Numero + " " + Nombre + " " + Categoria;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Canal() { }
        public Canal(int codigo, int numero, string nombre,string categoria)
        {
            Codigo = codigo;
            Numero = numero;
            Nombre = nombre;
            Categoria = categoria;
        }
    }
}
