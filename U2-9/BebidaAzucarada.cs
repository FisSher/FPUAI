using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_9
{
     class BebidaAzucarada:Bebida
    {
        public double Azucar { get; set; }
        public bool Promocion { get; set; }

        public BebidaAzucarada(int id, double litros, double precio, string marca, double azucar, bool promocion)
        {
            Id = id;
            Litros = litros;
            Precio = precio;
            Marca = marca;
            Azucar = azucar;
            Promocion = promocion;
        }

    }
}
