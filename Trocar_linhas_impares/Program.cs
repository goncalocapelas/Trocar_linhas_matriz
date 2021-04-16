using System;

namespace Trocar_linhas_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[,] mat = new int[10, 15];
            Random rd = new Random();
            
            Console.WriteLine();
            Console.WriteLine("Matriz Original");
            Console.WriteLine();
            //preenche a matriz
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                { 
                    mat[i, j] = rd.Next(1,9);
                }
            }
            Console.WriteLine();

            //Apresenta matriz original

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            //faz a troca das linhas pares pelas linhas impares
            Console.WriteLine();
            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 15; j++)
                {
                    if (i % 2 == 0)
                    {
                       
                        aux = mat[i, j];
                        mat[i, j] = mat[i + 1, j];
                        mat[i + 1, j] = aux;
                    }
                    
                }
            }

            //apresenta a matriz trocada
            Console.WriteLine();
            Console.WriteLine("Matriz trocada");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
