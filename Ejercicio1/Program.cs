using EjerciciosLogica.Ejercicio1;
using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vector = EjVectores.LlenarVector();
            //String.Join Convierte el vector en string y separa los valores con lo que definamos como primer parametro.
            Console.WriteLine("["+String.Join("-",vector)+"]");
            EjVectores.NumerDistinto(vector);
            Console.ReadLine();

        }
    }
}
