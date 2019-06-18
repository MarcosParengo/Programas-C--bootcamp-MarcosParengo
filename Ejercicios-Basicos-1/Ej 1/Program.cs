using System;

namespace Ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RepuestaEsUnTexto = false;
            string resp;
            do
            {
                Console.WriteLine("What is your name?");
                resp = Console.ReadLine();
                if (resp == "")
                {
                    Console.WriteLine("oops its seems like you've forgotten your name, lets try again");
                }
                else
                {
                    RepuestaEsUnTexto = true;
                }
            } while (RepuestaEsUnTexto == false);
            Console.WriteLine("Hello {0}", resp);
            Console.WriteLine("Hope you ejoy your stay here ahre");
        }
    }
}
