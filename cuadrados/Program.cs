using System;

namespace cuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            char cuenta;
            Console.WriteLine("Indique un numero");
            x = Convert.ToChar(Console.Read());
            while (x <= 0)
            {
                Console.WriteLine("Error, el numero debe ser mayor a 0");
            }
                cuenta = Convert.ToChar( x * x);
                //cuenta = x * x;
                Console.WriteLine(x + " al cuadrado es " + cuenta);
        }
    }
}
