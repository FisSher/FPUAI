using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.ExcepcionPers
{
    internal class CanalExistenteException:Exception
    {
        public override string Message
        {
            get { return "El canal ya existe"; }
        }
    }
}
