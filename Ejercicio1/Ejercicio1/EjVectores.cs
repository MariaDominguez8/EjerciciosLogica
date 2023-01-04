using System;


namespace EjerciciosLogica.Ejercicio1
{
    internal class EjVectores
    {
        /*---- MÈTODOS ----*/

        /**
         * Este método pùblico se encarga de devolver el nùmero "distinto" en un
         * vector dependiendo si el vector de enteros es de enteros par o impar.
         * @param v es el vector creamos tomando los valores de la consola.
         */
        public static void NumerDistinto(int[] vector)
        {
            int esPar = 0;
            int esImpar = 0;
            int numP = 0;
            int numI = 0;
           /* for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    esPar++;
                    numP = v[i];
                }
                else
                {
                    esImpar++;
                    numI = v[i];
                }
            }*/
            foreach (int i in vector)
            {
                if (i % 2 == 0)
                {
                    esPar++;
                    numP = i;
                }
                else
                {
                    esImpar++;
                    numI = i;
                }
            }
            if (esPar < esImpar)
            {
                Console.WriteLine($"El numero distinto es:  {numP}");
            }
            else
            {
                Console.WriteLine($"El numero distinto es: {numI}");
            }   

        }

        /**
         * Este método pùblico se encarga de llenar un vector con valores ingresados por 
         * consola.
         * @return El vector con los valores ingresados. En caso de haber ingresado una longitud menor
         * a 3, muestra un mensaje para que orientar al usuario a ingresar la longitud deseada.
         */
        public static int[] LlenarVector()
        {
            Console.WriteLine("Ingrese la longitud del el vector: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 3) {
                Console.WriteLine("Ingrese un valor mayor o igual a 3 para la longitud del vector:");
                n = int.Parse(Console.ReadLine());
            }
            int[] vector = new int[n];
            Console.WriteLine("Ingrese los valores que desee: ");
            for (int i = 0; i < n; i++)
            {
               vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
         
        }


    }
}
