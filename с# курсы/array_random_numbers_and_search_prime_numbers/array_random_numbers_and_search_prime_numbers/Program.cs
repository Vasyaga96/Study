using System;
using System.Collections.Generic;

namespace array_random_numbers_and_search_prime_numbers
{
    class Program
    {
        static int[] GenerationRandomArray(int size)
        {
            int[] arrRandom = new int[size];

            Random rnd = new Random();
            for (int i = 0; i < arrRandom.Length; i++)
            {
                arrRandom[i] = rnd.Next(1, 100);
            }
            return arrRandom;
        }
        static void PrintStatic(int[] arrRandom)
        {
            for (int i = 0; i < arrRandom.Length - 1; i++)
            {
                Console.Write($"{arrRandom[i]}, ");
            }
            Console.WriteLine(arrRandom[^1]);
        }

        static List<int> SearchPrimeNumbers(int[] arrRandom)
        {
            bool NumberPrime = true;
            List<int> arrPrimeNumbers = new List<int> { };
            for (int i = 0; i < arrRandom.Length; i++)
            {
                for (int j = (int)Math.Sqrt(arrRandom[i]); j > 1; j--)
                {
                    NumberPrime = true;
                    if (arrRandom[i] % j == 0)
                    {
                        NumberPrime = false;
                        break;
                    }
                }
                if (NumberPrime)
                {
                    arrPrimeNumbers.Add(arrRandom[i]);
                }
            }
            return arrPrimeNumbers;
        }

        static void PrintDinamic(List<int> arrRandom)
        {
            for (int i = 0; i < arrRandom.Count - 1; i++)
            {
                Console.Write($"{arrRandom[i]}, ");
            }
            Console.WriteLine(arrRandom[^1]);
        }

        static List<int> Sort(List<int> arr)
        {
            bool needSort = true;
            while (needSort)
            {
                needSort = false;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int k = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = k;
                        needSort = true;
                    }
                }            
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] randomArr = GenerationRandomArray(n);
            PrintStatic(randomArr);
            List<int>arrPrimeNumbers = SearchPrimeNumbers(randomArr);
            Sort(arrPrimeNumbers);
            PrintDinamic(arrPrimeNumbers);
        }
    }
}
