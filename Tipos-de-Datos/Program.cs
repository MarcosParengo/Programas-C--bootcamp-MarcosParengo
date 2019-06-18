using System;

namespace tipos_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero1 = 2147483647;
            short short1 = -32768;
            bool boolean1 = true;
            long long1 = 9223372036854775807;
            
            Console.WriteLine("Entero: {0}",entero1);
            Console.WriteLine("Short: {0}",short1);
            Console.WriteLine("boolean: {0}",boolean1);
            Console.WriteLine("long: {0}",long1);
        }
    }
}
