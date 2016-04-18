using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 25";

            int[] A = new int[20] {2, 5, 1, 7, 8, 6, 3, 4, -9, -4, -8, -3, 10, -7, 11, 15, 19, -20, 35, 65};

            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i] + "; ");
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    int Aux;

                    if (A[i] < A[j])
                    {
                        Aux = A[i];
                        A[i] = A[j];
                        A[j] = Aux;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i] + "; ");
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20 - 1; j++)
                {
                    int Aux;

                    if (A[i] > A[j])
                    {
                        Aux = A[i];
                        A[i] = A[j];
                        A[j] = Aux;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(A[i] + "; ");
            }



            Console.ReadKey();
        }
    }
}
