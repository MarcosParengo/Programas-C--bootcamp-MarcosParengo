namespace ejercicio_objetos
{
    public class Auto: Vehiculo
    {
        double velocidad;
        const int cantRuedas = 4;
        public Auto(string marca, string modelo, string patente, string motor) : base(marca, modelo, patente, motor) { }

        public override void Frenar()
        {
            velocidad = 0;
        }
        public override void Acelerar(double _aceleracion)
        {
            velocidad = _aceleracion;
        }
    }
}