using System;

namespace naranja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que fruta me estas dando??");
            String fruta = Console.ReadLine();

            switch (fruta.ToLower())
            {
                case "manzana":
                    Console.WriteLine("Se hace tarta");
                    break;

                case "pomelo":
                    Console.WriteLine("Terma con pomelo");
                    break;

                case "naranja":
                    Console.WriteLine("Que rico juguito me acabo de hacer");
                    break;

                default:
                    Console.WriteLine("Fruta al macrista sucio");
                    break;
            }
        }
    }
}
