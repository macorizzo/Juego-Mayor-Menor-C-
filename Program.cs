using System;

namespace Juego_Mayor_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numActual = 0;
            int numSig;
            String signo;
            Random numRandom = new Random();
            Console.WriteLine("El numero actual es: " + numActual);
            bool resul = false;
            int contador = 0;
            while (resul == false)
            {
                do
                {
                    Console.WriteLine("Ingrese '+' si considera que el siguiente sera mayor o '-' si considera que sera menor");
                    signo = Console.ReadLine();
                } while (!signo.Equals("+") && !signo.Equals("-"));

                numSig = numRandom.Next(-10, 11);
                Console.WriteLine("El que salio es: " + numSig);

                if ((signo.Equals("+") && numSig >= numActual) || (signo.Equals("-") && numSig <= numActual)) 
                {
                    Console.WriteLine("Acertaste!, sigue el juego");
                    numActual = numSig;
                    contador++;
                } else
                {
                    Console.WriteLine("Perdiste! Fin del juego");
                    Console.WriteLine("Acertaste " + contador + " veces!.");
                    resul = true;
                }
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
            
        }
    }
}
