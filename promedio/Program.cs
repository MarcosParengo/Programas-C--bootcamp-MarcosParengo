using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int cantidad = 0;
            int cuenta = 0;
            decimal resultado = 0m;
            Console.WriteLine("Ingrese un numero");
            valor = Console.ReadLine();

            int.TryParse(valor, out cantidad);

            Console.WriteLine(cantidad);

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese el " + (i+1) + "° valor a promediar");
                
                valor = Console.ReadLine();
                numeros[i] = Int32.Parse(valor);
                cuenta = cuenta + numeros[i];
            }

            resultado = (decimal)cuenta / (decimal)cantidad;

            Console.WriteLine(resultado);
        }
    }
}
