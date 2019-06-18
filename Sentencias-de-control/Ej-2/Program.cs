using System;

namespace ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            string resp = Console.ReadLine();
            int result = 0;
            int resultadoFinal = 0;
            bool n = false;

            for (int i = 0; i < 1; i++) //Recorremos el string.

                if (Char.IsLetter((char)resp[i]))


                    Console.WriteLine("{0} es una letra. Ingrese un número.", resp[i]);
                else if (Char.IsNumber((char)resp[i]))
                {
                    n = true;
                    result = Int32.Parse(resp);
                    resultadoFinal = result * result;
                    switch (resp)
                    {
                        case "0":
                            Console.WriteLine("Error. El número ingresado debe ser distinto a cero.");
                            break;
                        default:
                            if (n == true)
                                Console.WriteLine("El cuadrado del número ingresado es {0}.", resultadoFinal);
                            break;
                    }
                }
        }
    }
}