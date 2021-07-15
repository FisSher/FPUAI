using SegundoParcial.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    
    public class Paquete
    {
        public event EventHandler<EstadoArgumentos> ChequeaEstado;
        private EstadoArgumentos argumento = new EstadoArgumentos();

        #region propiedades
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Abono { get; set; }
        public string Estado { get; set; }
        public List<Cliente> LClientes { get; set; }
        public List<Canal> LCanales { get; set; }
        #endregion

        public string ValidarEstado(string mensaje)
        {
            if (this.ChequeaEstado != null)
            {
                argumento.DescripcionDelEstado = mensaje;
            }
            ChequeaEstado(this, argumento);
            return argumento.DescripcionDelEstado;
        }

        public virtual double CalcularAbono(double precio)
        {
            return precio;
        }

        public override string ToString()
        {
            return Codigo + " " + Nombre + " " + Abono;
        }
    }
}
