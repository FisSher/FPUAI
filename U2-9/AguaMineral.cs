using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_9
{
    class AguaMineral : Bebida
    {

        public string Origen { get; set; }

        public AguaMineral(int id,double litros,double precio,string marca,string origen){
            Id = id;
            Litros = litros;
            Precio = precio;
            Marca = marca;
            Origen = origen;        
        }
    }
}
