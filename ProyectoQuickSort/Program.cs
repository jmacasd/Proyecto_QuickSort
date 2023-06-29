using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoQuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 20, 15, 30, 25, 40, 45, 50, 35, 5, 10 };
            
            Console.WriteLine("Sin ordenar: ");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }

            Ordenar_QuickSort(arreglo, 0, arreglo.Length - 1);

            Console.WriteLine("");
            Console.WriteLine("Ordenado: ");
            
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento);
                Console.Write(",");
            }

            Console.ReadLine();
        }

        static void Ordenar_QuickSort(int[] arreglo, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int puntoDivision = Division(arreglo, izquierda, derecha);
                
                Ordenar_QuickSort(arreglo, izquierda, puntoDivision);
                
                Ordenar_QuickSort(arreglo, puntoDivision + 1, derecha);
            }
        }
        
        static int Division(int[] arreglo, int izquierda, int derecha)
        {
            int puntoDivision = arreglo[izquierda];
            
            while (true)
            {
                while (arreglo[izquierda] < puntoDivision)
                {
                    izquierda++;
                }

                while (arreglo[derecha] > puntoDivision)
                {
                    derecha--;
                }
                
                if (izquierda >= derecha)
                {
                    return derecha;
                }
                else
                {
                    int aux = arreglo[izquierda];
                    
                    arreglo[izquierda] = arreglo[derecha];
                    
                    arreglo[derecha] = aux;
                    
                    derecha--; izquierda++;
                }
            }
        }
    }
}
