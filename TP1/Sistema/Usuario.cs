using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public int NivelPermisos { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public readonly string NombreUsuario;
        public string Password
        {
            set { Password = value; }

        }








    }




}
