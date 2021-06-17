namespace U3_P2_1
{
    public class Vehiculo
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Kilometraje { get; set; }

        public Vehiculo()
        {
        }

        public Vehiculo(int _codigo, string _tipo, string _marca, string _modelo, double _kilometraje)
        {
            Codigo = _codigo;
            Tipo = _tipo;
            Marca = _marca;
            Modelo = _modelo;
            Kilometraje = _kilometraje;
        }
    }
}