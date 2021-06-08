using System;

namespace array2
{
    class Program
    {
        public static int max;
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

            max = Maximum(arr);
            Console.WriteLine($"Самое большое число в массиве {max}");

        }
        private static int Maximum(int[] arr)
        {
            max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
