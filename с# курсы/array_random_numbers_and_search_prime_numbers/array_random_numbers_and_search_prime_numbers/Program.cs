using System;
using System.Collections.Generic;

namespace array_random_numbers_and_search_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());

            bool NumberPrime = true;
            int[] arr = new int[n];
            List<int> arrPrimeNumbers = new List<int> {};

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
                for(int j = arr[i] - 1; j > 1; j--)
                {
                    if(arr[i] % j == 0)
                    {
                        NumberPrime = false;
                        break;
                    }
                }
                if(NumberPrime == true)
                {
                    arrPrimeNumbers.Add(arr[i]);
                }
                NumberPrime = true;
            }
            for (int i = 0; i < arrPrimeNumbers.Count - 1; i++)
            {
                Console.Write($"{arrPrimeNumbers[i]}, ");
            }
            Console.Write(arrPrimeNumbers[^1]);
        }
    }
}

/*if (arr[i] % j == 0)
{
    break;
}
else
{
    arrPrimeNumbers.Add(arr[i]);
    break;
}*/