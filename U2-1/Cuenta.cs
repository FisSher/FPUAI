namespace U2_1
{
    public class Cuenta
    {
        //Defino las propiedades no me interesa que ninguna clase exterior las pueda ver.
        private string Titular { get; set; }

        private double Cantidad { get; set; }

        public Cuenta()
        {
        }

        //El titular va a ser obligatorio no importa como lo quiera construir.
        //También se puede hacer this.titular = nombreTitular, lo mantengo con diferente nombre por legibilidad.
        public Cuenta(string nombreTitular)
        {
            Titular = nombreTitular;
        }

        public Cuenta(string nombreTitular, double cantidadCuenta)
        {
            Titular = nombreTitular;
            Cantidad = cantidadCuenta;
        }

        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
                Cantidad += cantidad;
            return Cantidad;
        }

        public double Retirar(double cantidad)
        {
            if (Cantidad - cantidad < 0)
                Cantidad = 0;
            else
                Cantidad -= cantidad;

            return Cantidad;
        }
    }
}