using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPn2.Interfaces
{
    //TODO no tengo idea que hacer con interfaces,tengo que pensar alguna utilidad
   
    public interface IImprimible
    {

        string Nombre { get; set; }
        string Apellido { get; set; }

        string Imprimir(string Nombre, string Apellido);
    }
}
