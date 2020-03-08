using System;

namespace Casoides
{
    class Program
    {
        static void Main(string[] args)
        {
            Puerta puerta = new Puerta("rojo comunista");
            puerta.setColor("Rojo");

            Casa casa = new Casa(342.4,puerta);

            casa.ShowData();
        }
    }
}
