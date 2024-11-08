using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 30;
            int[] array = new int[N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Початковий масив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            
            int zeroIndex = -1;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == 0)
                {
                    zeroIndex = i;
                    break;
                }
            }

            if (zeroIndex != -1)
            {
                for (int i = 0; i < zeroIndex - 1; i++)
                {
                    for (int j = 0; j < zeroIndex - 1 - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("У масиві немає нульового елемента.");
            }

            Console.WriteLine("Перетворений масив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
