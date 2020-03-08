using System;

/*Write a C# Sharp program to accept the height of a person in centimeter and
categorize the person according to their height.
Test Data : 135
Expected Output :
The person is Dwarf.*/

namespace ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique su altura en cm");
            Decimal altura = Convert.ToDecimal(Console.ReadLine());
            int caso = 0;

            if (altura < 130)
            {
                Console.WriteLine("Enano");
            }else if (altura > 185)
            {
                Console.WriteLine("Alto");
            }else if (altura > 200)
            {
                Console.WriteLine("Super alto");
            }else if (altura > 130 && altura < 185)
            {
                Console.WriteLine("Altura promedio");
            }

        }
    }
}
