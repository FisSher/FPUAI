using System;

namespace TPn2.Excepcion
{
    //TODO implementar en botón agregar a curso
    internal class ListaCompletaException : Exception
    {
        public override string Message
        {
            get { return "El curso está completo"; }
        }
    }
}