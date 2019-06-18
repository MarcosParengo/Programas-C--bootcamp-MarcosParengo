using System;

namespace ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool laRespuestaEsUnNumero = false;
            bool laRespuestaEsUnNumero2 = false;
            string resp2;
            int numero;
            int respint = 0;
            int numerador = 0;
            decimal resultado;
            do
            {
                Console.WriteLine("Ingrese un numero");
                string resp = Console.ReadLine();
                if (Char.IsNumber((char)resp[i]) && resp != "0")
                {
                    laRespuestaEsUnNumero = true;
                    respint = Int32.Parse(resp);
                }
                else
                {
                    Console.WriteLine("La respuesta debe ser un numero");
                }
            } while (laRespuestaEsUnNumero == false);
            while (i < respint)
            {
                do
                {
                    Console.WriteLine("Ingrese el {0}° numero", i + 1);
                    resp2 = Console.ReadLine();
                    if (Char.IsNumber((char)resp2[0]) && resp2 != "0")
                    {
                        laRespuestaEsUnNumero2 = true;
                    }
                    else
                    {
                        Console.WriteLine("La respuesta debe ser un numero");
                    }
                } while (laRespuestaEsUnNumero2 == false);

                numero = Int32.Parse(resp2);
                numerador = numerador + numero;
                i = i + 1;
                laRespuestaEsUnNumero2 = false;
                resp2 = null;
            }
            resultado = (decimal)numerador / (decimal)respint;
            Console.WriteLine("El promedio de los numeros ingresados es {0}", resultado);
        }
    }
}
