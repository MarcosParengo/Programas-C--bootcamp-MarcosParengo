using System;

namespace ejercicio_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un auto
            Auto auto = new Auto("Fiat","147","ABC123","Mabuchi12Volts");

            //acelerar el auto
            auto.Acelerar(100);

            //frenar el auto
            auto.Frenar();

            //crear un auto
            Bus bus = new Bus("aaa","bbb","ccc","ddd");
        }
    }
}