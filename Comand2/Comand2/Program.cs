using System;

namespace Comand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество комманд");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество соревнований");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = new int[n, m];
            int[] arrNumber = new int[n];
            int[] arrPoint = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                arrNumber[i] = i;
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                    sum += arr[i, j];
                }
                arrPoint[i] = sum;
            }

            bool needSort = true;
            while (needSort)
            {
                needSort = false;
                for (int i = 0; i < arrPoint.Length - 1; i++)
                {
                    if (arrPoint[i] > arrPoint[i + 1])
                    {
                        int k = arrPoint[i];
                        arrPoint[i] = arrPoint[i + 1];
                        arrPoint[i + 1] = k;
                        int l = arrNumber[i];
                        arrNumber[i] = arrNumber[i + 1];
                        arrNumber[i + 1] = l;
                        needSort = true;
                    }
                }
            }

            for(int i = 0; i<arrNumber.Length; i++)
            {
                Console.WriteLine($"{i + 1} место у команды {arrNumber[i]}");
            }
        }
    }
}
