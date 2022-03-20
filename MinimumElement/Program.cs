using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте.\n");
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] ArrayElement = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                ArrayElement[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue;
            for (int i = 0; i < size; i++)
            {
                if (ArrayElement[i] < min)
                {
                    min = ArrayElement[i];
                }
            }
            Console.Write($"\nМинимальное значение: {min}");

            Console.ReadKey();
        }
    }
}
