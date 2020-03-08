namespace ejercicio_objetos
{
    public abstract class Vehiculo
    {
        public string Marca {get;}
        public string Modelo {get;}
        public string Patente {get;}
        private string Motor {get;}

        public Vehiculo(string marca, string modelo, string patente, string motor)
        {
            Marca =marca;
            Modelo = modelo;
            Patente = patente;
            Motor = motor;
        }

        public abstract void Frenar();
        public abstract void Acelerar(double aceleracion);

    }
}