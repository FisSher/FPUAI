using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5_0
{
    internal class Calculadora
    {
        internal delegate void Calcular(int num1, int num2);

        internal Calcular calcular;
    }
}
