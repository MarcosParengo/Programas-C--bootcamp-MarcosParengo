using System;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Primer operacion

            int valor1 = -1;
            int valor2 = 4;
            int valor3 = 6;
            int R1 = valor1 + valor2 * valor3;

            //Segunda operacion

            int valor4 = 35;
            int valor5 = 5;
            int valor6 = 7;
            int R2 = (valor4 + valor5) % valor6;

            
            //Tercer operacion
            
            int valor8 = 14;
            int valor9 = -4;
            int valor10 = 6;
            int valor11 = 11;
            int R3 = valor8 + valor9 * valor10 / valor11;

            //Cuarta operacion

            int valor7 = 2;
            int valor12 = 15;
            int valor13 = 6;
            int valor14 = 1;
            int valor15 = 7;
            int valor16 = 2;
            int R4 = valor7 + valor12 / valor13 * valor14 - valor15 % valor16;

            Console.WriteLine("{0} + {1} * {2} = {3}", valor1, valor2, valor3, R1); //Lo que esta entre comillas se muestra en la consola, lo que esta entre corchetes, ademas, se reemplaza por la variable que se ponga despues de cerrar comillas, dependiendo el numero (El que este entre los corchetes) y la posicion (de la variable)
            Console.WriteLine("( {0} + {1} ) % {2} = {3}", valor4, valor5, valor6, R2);
            Console.WriteLine(" {0} + {1} * {2} / {3} = {4} ", valor8, valor9, valor10, valor11, R3);            
            Console.WriteLine(" {0} + {1} / {2} * {3} - {4} % {5} = {6} ", valor7, valor12, valor13, valor14, valor15, valor16, R4);
            

        }
    }
}
