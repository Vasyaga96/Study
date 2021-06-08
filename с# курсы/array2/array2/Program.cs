using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} число массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine(arr[^1]);

            Console.WriteLine("Введите число которое надо найти: ");
            int numberSearch = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numberSearch)
                {
                    Console.WriteLine($"Ваше число {numberSearch} в массиве под индексом {i}");
                    break;
                }
            }
        }
    }
}
