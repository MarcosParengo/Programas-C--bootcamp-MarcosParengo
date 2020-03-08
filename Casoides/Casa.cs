using System;

namespace Casoides
{
    public class Casa
    {
        private double area;
        protected Puerta puerta;

        public Casa (double area, Puerta puerta)
        {
            this.area = area;
            this.puerta = puerta;
        }

        public double getArea()
        {
            return area;
        }

        public void ShowData()
        {
            Console.WriteLine("Soy una casa, mi area es de " + area + "m²");
        }
    }
}