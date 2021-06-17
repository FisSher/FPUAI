using System;

namespace U4_2
{
    public class Producto : IComparable
    {
        #region Props
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
        #endregion


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

 
        public override string ToString()
        {
            return CodigoUnico.ToString() + " - " + Nombre + " - " + Marca + " - " + Cantidad + " - " + Descripcion;
        }

        /// <summary>
        /// Otra posibilidad para comparar por nombre o marca ¿Uso esto?
        /// </summary>
        //public static Comparison<Producto> OrdenaMarca = (a, b) => a.Marca.CompareTo(b.Marca);
        //public static Comparison<Producto> OrdenaNombre = (a, b) => a.Nombre.CompareTo(b.Marca);
    }
}