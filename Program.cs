using System;

namespace App
{
    class Programa
    {
        static int busquedaBinaria(int[] arreglo, int busqueda, int izquierda, int derecha)
        {
            if (izquierda > derecha)
            {
                return -1;
            }

            int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
            int valorCentral = arreglo[indiceCentral];
            if (valorCentral == busqueda)
            {
                return indiceCentral;
            }
            if (busqueda < valorCentral)
            {
                derecha = indiceCentral - 1;
            }
            else
            {
                izquierda = indiceCentral + 1;
            }
            return busquedaBinaria(arreglo, busqueda, izquierda, derecha);
        }
        static int busquedaBinariaWhile(int[] arreglo, int busqueda)
        {
            int izquierda = 0, derecha = arreglo.Length - 1;
            while (izquierda <= derecha)
            {

                int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
                int valorCentral = arreglo[indiceCentral];

                if (valorCentral == busqueda)
                {
                    return indiceCentral;
                }
                if (busqueda < valorCentral)
                {
                    derecha = indiceCentral - 1;
                }
                else
                {
                    izquierda = indiceCentral + 1;
                }

            }
            return -1;

        }

        static void Main(string[] args)
        {
            int[] numeros = { 50, 28, 11, 96, 82, 9, 45, 32, 1 };
            Array.Sort<int>(numeros, new Comparison<int>((n1, n2) => n1.CompareTo(n2)));
            Console.WriteLine("El arreglo es:");
            Console.WriteLine();
            foreach (var numero in numeros)
            {
                Console.Write(numero + ", ");
            }
            Console.WriteLine();
            int busqueda = 1;
            int indice = busquedaBinaria(numeros, busqueda, 0, numeros.Length - 1);

            if (indice == -1)
            {
                Console.WriteLine("La búsqueda no existe");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El número {0}, existe en la posición {1}", busqueda, indice);
            }
            Console.ReadLine();
        }
    }
}
