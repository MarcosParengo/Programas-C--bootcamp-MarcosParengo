namespace Casoides
{
    public class Persona
    {
        protected string nombre;
        protected Casa casa;

        public Persona (string nombre, Casa casa)
        {
            this.nombre = nombre;
            this.casa = casa;
        }

        double area = casa.getArea();

        public void ShowData()
        {
            Console.WriteLine("Soy " + nombre + "y mi casa tiene " + casa.getArea().ToString + "m2 y una puerta " + casa.getPuerta().getColor);
        }
    }
}