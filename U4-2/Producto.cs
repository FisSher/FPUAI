using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_2
{
    public class Producto:IComparable
    {
        private int _codigoUnico;

        public int CodigoUnico
        {
            get { return _codigoUnico; }
            set { _codigoUnico = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Producto p = (Producto)obj;
                return Nombre.CompareTo(p.Nombre);
            }
        }
        

    }
}
