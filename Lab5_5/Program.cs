using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1
");
            Console.WriteLine("");

            Console.WriteLine("Введите размерность массива:");
            var dim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат :");
            Console.WriteLine("");

            int[,] array = new int[dim, dim];

            
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    
                    array[i, j] = i % 2 != 0 ? (j % 2 != 0 ? 1 : 0) : (j % 2 != 0 ? 0 : 1);

                    Console.Write(array[i, j] + " ");
                }

               
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
