using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_3
{
    interface IValidable
    {
        string InfoValidacion { get; set; }

        //bool EsValido(object T);
        bool EsValido();
    }
}
