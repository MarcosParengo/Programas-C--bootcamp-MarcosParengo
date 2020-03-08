using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String num1;
            String num2;
            String num3;
            String resultado;
            int cuenta1;
            cuenta1 = -1 + 4 * 6;
            Console.WriteLine("Por favor indique su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("el resultado de prueba es " + cuenta1);
            Console.WriteLine("Seleccione numeros para sumarlos");
            num1 = Console.ReadLine();
            Console.WriteLine("");
            num2 = Console.ReadLine();
            Console.WriteLine("");
            num3 = Console.ReadLine();
            Console.WriteLine("");
            resultado = num1 + num2 + num3;
            Console.WriteLine("La suma entre " + num1 + " + " + num2 + " + " + num3 + " es " + resultado);
        }
    }
}
