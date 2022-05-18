using System;

namespace array_random_numbers_and_search_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine(arr[^1]);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1 || arr[i] == 2 || arr[i] == 3)
                {
                    Console.WriteLine(arr[i]);
                }
                else if(arr[i] % 2 != 0 && arr[i] % 3 != 0 )
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
