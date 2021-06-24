using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace U6_1
{
    public class Cliente
    {
        public event DelActividad AnotarActividad;

        //void Actividad != null siempre

        public void Anotar()
        {
            if (this.AnotarActividad != null)
            {
                AnotarActividad("Actividad: ");
            }
        }
    }
}