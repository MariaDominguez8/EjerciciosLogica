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
            if (esPar < esImpar && esPar !=0)
            {
                Console.WriteLine($"El numero distinto es:  {numP}");
            }
            else if(esImpar < esPar && esImpar !=0)
            {
                Console.WriteLine($"El numero distinto es: {numI}");
            }   

        }

        /**
         * Este método pùblico se encarga de llenar un vector con valores ingresados por 
         * consola.
         * @return El vector con los valores ingresados. En caso de haber ingresado una longitud menor
         * a 3, se retornarà el valor -1 y el mensaje de error.
         */
        public static int[] LlenarVector()
        {
           
            string error = "Ingrese un valor mayor o igual a 3 para la longitud del vector";
            int n = 0;
            Console.WriteLine("Ingrese la longitud del el vector: ");
            n = int.Parse(Console.ReadLine());
            if (n < 3) {
            int[] errorr = new int[1] { -1 };
            Console.WriteLine(error);
            return errorr;
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
