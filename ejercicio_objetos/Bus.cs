namespace ejercicio_objetos
{
    public class Bus:Vehiculo
    {
        Rueda[] ruedas;
        
        public Bus(string marca, string modelo, string patente, string motor) : base(marca, modelo, patente, motor)
        {
            ruedas = new Rueda[6];
            for(int i = 0; i < ruedas.Length;i++)
            {
                ruedas[i] = new Rueda();
            }
        }
        public override void Frenar()
        {
            for (int i = 0; i < ruedas.Length; i++)
            {
                ruedas[i].Frenar();
            }
        }
        public override void Acelerar(double _aceleracion){
            for (int i = 0; i < ruedas.Length; i++)
            {
                ruedas[i].Acelerar(_aceleracion);
            }
        }
    private class Rueda
    {
        double velocidad;

        public Rueda()
        {
            
        }
        public void Frenar()
        {
            velocidad = 0;
        }
        public void Acelerar(double _aceleracion)
        {
            velocidad = _aceleracion;
        }
    }
    }
}