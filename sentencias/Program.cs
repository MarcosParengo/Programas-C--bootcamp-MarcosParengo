//Tarea de calc promedios. Tarea 1
using System;

namespace sentencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, cuenta;
            Console.WriteLine("Ingrese un numero (hasta el 11)");
            x = Convert.ToInt32(Console.ReadLine());
            if (x.Equals(1))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1) / x;
                dar ();
            }
            if (x.Equals(2))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2) / x;
                dar ();
            }
            if (x.Equals(3))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3) / x;
                dar ();
            }
            if (x.Equals(4))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4) / x;
                dar ();
            }
            if (x.Equals(5))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5) / x;
                dar ();
            }
            if (x.Equals(6))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6) / x;
                dar ();
            }
            if (x.Equals(7))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                x7 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6 + x7) / x;
                dar ();
            }
            if (x.Equals(8))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                x7 = Convert.ToInt32(Console.ReadLine());
                x8 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8) / 8;
                dar ();
            }
            if (x.Equals(9))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                x7 = Convert.ToInt32(Console.ReadLine());
                x8 = Convert.ToInt32(Console.ReadLine());
                x9 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / x;
                dar ();
            }
            if (x.Equals(10))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                x7 = Convert.ToInt32(Console.ReadLine());
                x8 = Convert.ToInt32(Console.ReadLine());
                x9 = Convert.ToInt32(Console.ReadLine());
                x10 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10) / x;
                dar ();
            }
            if (x.Equals(11))
            {
                pedir();
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                x3 = Convert.ToInt32(Console.ReadLine());
                x4 = Convert.ToInt32(Console.ReadLine());
                x5 = Convert.ToInt32(Console.ReadLine());
                x6 = Convert.ToInt32(Console.ReadLine());
                x7 = Convert.ToInt32(Console.ReadLine());
                x8 = Convert.ToInt32(Console.ReadLine());
                x9 = Convert.ToInt32(Console.ReadLine());
                x10 = Convert.ToInt32(Console.ReadLine());
                x11 = Convert.ToInt32(Console.ReadLine());
                cuenta = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11) / x;
                dar ();
            }

            void pedir ()
            {
                Console.WriteLine("escriba " + x + " numeros");
            }

            void dar ()
            {
                Console.WriteLine("Su promedio es " + cuenta);
            }

        }  
    }
}
