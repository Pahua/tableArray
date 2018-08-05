using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableArray
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 12, 120, 25, 3, 89, 1001 };
            int columnas = 3;

            solution(a, columnas);

            Console.ReadLine();
        } // main


        static void solution(int[] arreglo, int k)
        {
            int Max = arreglo.Max();
            int cols = k;
            int filas = (arreglo.Length / k) + arreglo.Length % k;
            int[,] arregloNuevo = new int[filas, cols];

            //Llena nuevo arreglo 
            int p = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (p < arreglo.Length)
                    {
                        arregloNuevo[i, j] = arreglo[p];
                        p++;
                    }
                    else arregloNuevo[i, j] =0;
                 }
            }// PASAR A STRING, PARA MEDIR LA LONGITUD DE LA CADENA
            //EN STRING, DECLARAR NULO O VACIO LOS ESPACIOS QUE NO SE USEN

            for (int r = 0; r < filas; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write("{0,6} ", arregloNuevo[r, c]);
                }
                Console.WriteLine("\t");
            }

            //Darle formato




          

        }//fin solution


    }
}
