using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaçao_estruturada
{
    class Program
    {
        static void Troca(int[] vetor, int pos1, int pos2)
        {
            int aux = 0;
            aux = vetor[pos1];
            vetor[pos1] = vetor[pos2];
            vetor[pos2] = aux;
        }

        static void Imprime(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 12, 7, 15, 11, 27 };
            int posição1 = 0;
            int posição2 = 0;


            Imprime(vetor);
            do
            {
                Console.WriteLine("\n\n\nDigite a 1 posição");


                int pos1 = Int32.Parse(Console.ReadLine());
            } while (posição1 < 0 || posição1 > vetor.Length);

            do
            {
                Console.WriteLine("\n\n\nDigite a 2 posição");

                int pos2 = Int32.Parse(Console.ReadLine());
            } while (posição2 < 0 || posição2 > vetor.Length);
               

            Troca(vetor, 1, 3);
            Imprime(vetor);

            Console.ReadKey();
                              
        }
    }
}
