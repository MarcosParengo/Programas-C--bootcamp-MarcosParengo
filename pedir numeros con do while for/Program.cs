using System;

namespace programita
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("ingrese un numero");
            char cant = Convert.ToChar(Console.ReadLine());
            bool flag = false;
            do
            {
                if (char.IsNumber(cant))
                {
                    flag = false;
                }else
                {
                   Console.WriteLine("ingresa un numero bobo");
                }
            } while (flag);
            int cantInt = (int)Char.GetNumericValue(cant);
            int j = 0;
            while (cantInt > j)
            {
                Console.WriteLine("Pasame un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("su numero es " + numero);
                j = j + 1;
            }
        }
    }
}