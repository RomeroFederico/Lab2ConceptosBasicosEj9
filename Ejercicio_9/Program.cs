using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_9
{

    /*
    09.  Escribir un programa que imprima por pantalla una pirámide como
    la siguiente: 
 
    * 
    *** 
    ***** 
    ******* 
    ********* 

    El usuario indicará cuál será la altura de la pirámide ingresando  
    un número entero positivo. Para el ejemplo anterior la altura 
    ingresada fue de 5. 
 
    Nota: Utilizar estructuras repetitivas y selectivas. 
    */
     
    class Ejercicio_9
    {
        static void Main(string[] args)
        {
            int altura;

            Console.Title = "Ejercicio Nro. 9";

            Console.Write("Ingrese la altura de la piramide: ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese la altura de la piramide: ");
                }

                if (altura <= 0)
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese la altura de la piramide: ");
                }
            } while (altura <= 0);

            for (int j = 0; j < altura; j++, Console.WriteLine())
            {
                Console.Write("*");

                for (int i = 0; i < j; i++)
                    Console.Write("**");
            }

            Console.ReadKey();
        }
    }
}