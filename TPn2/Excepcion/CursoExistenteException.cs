using System;

namespace TPn2.Excepcion
{
    //TODO implementar en botón agregar a curso
    //Lo voy a cambiar por "el curso ya existe"
    //Lo cambié
    internal class CursoExistenteException : Exception
    {
        public override string Message
        {
            get { return "El curso ya existe"; }
        }
    }
}