using System;

namespace ej_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto:");

            string resp = Console.ReadLine();
            int CantNumeros = 0; //variable donde cuento la cantidad de numeros
            int CantLetras = 0; //variable donde cuento la cantidad de letras
            int CantMinusculas = 0; //variable donde cuento la cantidad de letras minusculas
            int CantMayusculas = 0; //variable donde cuento la cantidad de letras mayusculas
            int CantVocales = 0; //variable donde cuento la cantidad de letras vocales

            for (int i = 0; i < resp.Length; i++)//como el string es en relidad un vector, cuenta con Lenght cuantas posiciones tiene y repite todo lo que hay dentro del for hasta que i, que comienza en 0 y se le suma 1 cada vez que repite el ciclo, es igual al largo de la respuesta, es decir, recorre el string y hace las accionesw que hay dentro del for para cada caracter
            {
                if (Char.IsLetter((char)resp[i]))//Toma la posicion i del vector resp y con una funcion ya hecha se fija si el valor ascii de lo que haya en esta posicion es igual a alguno de el de una letra
                {
                    CantLetras = CantLetras + 1;//como la condicion anterior es verdadera suma uno a la variable en la que se cuentan la cantidad de letras del texto
                    if (Char.IsLower((char)resp[i]))//ahora se compara el valor de la posicion "i" del vector resp en ascii al de cualquier valor en ascii de las minusculas
                    {
                        CantMinusculas = CantMinusculas + 1;//Si la condicion anterior es verdadera se suma uno a la variable en la que se cuentan la cantidad de letras Minusculas del texto
                        if ((char)resp[i] == 97 || (char)resp[i] == 101 || (char)resp[i] == 105 || (char)resp[i] == 111 || (char)resp[i] == 117)//ahora se compara el valor ascii del caracter numero "i" con los valores ascii de las vocales minusculas
                        {
                            CantVocales = CantVocales + 1;//como la condicion anterior es verdadera se le suma 1 a la variable que guarda cuantas vocales hay en el texto
                        }

                    }
                    else if (Char.IsUpper((char)resp[i]))//ahora compara el valor de la posicion "i" del vector resp en ascii al de cualquier valor en ascii de las mayusculas
                    {
                        CantMayusculas = CantMayusculas + 1;//Si la condicion anterior es verdadera se suma uno a la variable en la que se cuentan la cantidad de letras Mayusculas del texto
                        if ((char)resp[i] == 65 || (char)resp[i] == 69 || (char)resp[i] == 73 || (char)resp[i] == 79 || (char)resp[i] == 85)//ahora se compara el valor ascii del caracter numero "i" con los valores ascii de las vocales mayusculas
                        {
                            CantVocales = CantVocales + 1;//como la condicion anterior es verdadera se le suma 1 a la variable que guarda cuantas vocales hay en el texto
                        }

                    }
                }
                else if (Char.IsNumber((char)resp[i]))//si lo demas es falso compara el valor de la posicion i del vector resp con cualquier valor ascii de los numeros
                {
                    CantNumeros = CantNumeros + 1;//si la condiucion anterior es verdadera le suma uno a la variable donde se cuentan cuantos numeros hay en el texto
                }
            }
            Console.WriteLine("Hay {0} numeros y {1} letras, de las cuales {2} son minusculas, {3} son mayusculas y {4} vocales", CantNumeros, CantLetras, CantMinusculas, CantMayusculas, CantVocales);//cuando ya hizo todas las acciones para todos los caracteres del texto muestera un mensaje con las variables, en los corcetes dentro de lo que se muestra(lo que esta entre comillas) va un numero, este corchete cunaod se ejecuta la orden se remplazan por lo que se ponga luego de cerradas las comillas si es 0 por lo primero, si es 1 por lo siguiente, etc
        }
    }
}
