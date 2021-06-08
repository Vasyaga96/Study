using System;

namespace array2
{
    class Program
    {
        private static int Maximum(int[] arr)
        {
            int max = arr[0];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return index;
        }

        static int Search(int[] arr, int numberSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numberSearch)
                {
                    return i;
                }
            }
            return -1;
        }

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

            int max = Maximum(arr);
            Console.WriteLine($"Самое большое число в массиве {arr[max]} под инсдексом {max}");
        }
    }
}
