using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрица
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrica = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i + j== 3)
                    {
                        matrica[i, j] = 1;
                    }
                    else
                    {
                        matrica[i, j] = 0;
                    }

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrica[i, j].ToString() + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
