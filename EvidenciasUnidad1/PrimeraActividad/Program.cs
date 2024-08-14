using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Esta funcion no recibe argumentos ni devuelve nada
        static void escribe(){
            Console.WriteLine("Hola Perritos");
        }

        //string representa las cadenas
        static void llamada(string msg)
        {
            Console.WriteLine("Dale perrito "+msg);
        }

        static int suma(int x,int y)
        {
            int suma = x + y;
            return suma;
        }

        static int resta(int x, int y)
        {
            int resta = x - y;
            return resta;
        }

        static int multi(int x, int y)
        {
            int multi = x * y;
            return multi;
        }

        static float divide(int x, int y)
        {
            float divide = x / y;
            return divide;
        }

        static string compara(int x, int y)
        {
            if ( x == y )
            {
                return "Son iguales";
            }
            else if(x < y)
            {
                return "X = " +x+ " Y = " +y+ ", X es menor a Y";
            }
            else
            {
                return "X es mayor a Y con X = " + x + " y Y = " + y; 
            }
        }

        static void ascendente(int i, int j)
        {
            for (int a = i; a <= j; a++)
            {
                Console.WriteLine("Ascendente = "+a);
            }
        }

        static void descendente(int i, int j)
        {
            for (int a = j; a >= i; a--)
            {
                Console.WriteLine("Descendente = " +a);
            }
        }

        //El main es la parte principal
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!!");
            escribe();
            llamada("vamoh a bailar");
            Console.WriteLine("La suma de los valores es "+suma(2, 3));
            Console.WriteLine("La resta de los valores es " + resta(2, 3));
            Console.WriteLine("La multiplicacion de los valores es " + multi(2, 3));
            Console.WriteLine("La divicion de los valores es " + divide(2, 3));
            Console.WriteLine("El resultado de la comparacion es: " + compara(1, 2));
            Console.WriteLine("El resultado de la comparacion es: " + compara(1, 1));
            Console.WriteLine("El resultado de la comparacion es: " + compara(3, 2));
            ascendente(1, 10);
            descendente(1, 10);
        }
    }
}