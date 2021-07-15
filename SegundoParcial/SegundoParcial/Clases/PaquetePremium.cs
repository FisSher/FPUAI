using SegundoParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PaquetePremium:Paquete
    {
        public override double CalcularAbono(double precio)
        {
            return precio + (precio*0.25);
        }

        public PaquetePremium() { }
        public PaquetePremium(int codigo, string nombre, double abono)
        {
            Codigo = codigo;
            Nombre = nombre;
            Abono = CalcularAbono(abono);
            Estado = "No suscrito";
            LCanales = new List<Canal>();
            LClientes = new List<Cliente>();

        }
    }
}
