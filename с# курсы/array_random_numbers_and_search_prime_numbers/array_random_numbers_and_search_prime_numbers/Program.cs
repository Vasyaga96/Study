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
            bool needSort = true;
            int[] arrRandom = new int[n];
            List<int> arrPrimeNumbers = new List<int> {};

            Random rnd = new Random();
            for (int i = 0; i < arrRandom.Length; i++)
            {
                arrRandom[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < arrRandom.Length - 1; i++)
            {
                Console.Write($"{arrRandom[i]}, ");
            }
            Console.WriteLine(arrRandom[^1]);

            for (int i = 0; i < arrRandom.Length; i++)
            {
                for(int j = arrRandom[i] - 1; j > 1; j--)
                {
                    if(arrRandom[i] % j == 0)
                    {
                        NumberPrime = false;
                        break;
                    }
                }
                if(NumberPrime == true)
                {
                    arrPrimeNumbers.Add(arrRandom[i]);
                }
                NumberPrime = true;
            }

            while (needSort)
            {
                needSort = false;
                for (int i = 0; i < arrPrimeNumbers.Count - 1; i++)
                {
                    if (arrPrimeNumbers[i] > arrPrimeNumbers[i + 1])
                    {
                        int k = arrPrimeNumbers[i];
                        arrPrimeNumbers[i] = arrPrimeNumbers[i + 1];
                        arrPrimeNumbers[i + 1] = k;
                        needSort = true;
                    }
                }
            }

            for (int i = 0; i < arrPrimeNumbers.Count - 1; i++)
            {
                Console.Write($"{arrPrimeNumbers[i]}, ");
            }
            Console.Write(arrPrimeNumbers[^1]);
        }
    }
}

/*if (arrRandom[i] % j == 0)
{
    break;
}
else
{
    arrPrimeNumbers.Add(arrRandom[i]);
    break;
}*/