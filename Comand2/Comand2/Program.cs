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

            int[,] arr = new int[n, m]; //массив команд и соревнований


            
            static int[,] TwoDimencionalRandomArr (int[,] arr)
            {
                Random rnd = new Random();
                for (int i = 0; i < arr.GetLength(0); i++) //пробежались по командам
                {
                    for (int j = 0; j < arr.GetLength(1); j++) //пробежались по сорревнованиям
                    {
                        arr[i, j] = rnd.Next(1, 10); //указав номер команды и номер соревнования заносим баллы рандомно
                    }
                }
                return arr;
            }

            static int[] Point (int[,] arr)
            {
                int[] arrPoint = new int[n]; //массив для суммы очков каждой команды
                for (int i = 0; i < arr.GetLength(0); i++) //цикл подсчет суммы очков каждой команды
                {
                    int sum = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sum += arr[i, j];
                    }
                    arrPoint[i] = sum;
                }
                return arrPoint;
            }

            static int[] NumberComand(int[] arr)
            {
                int[] arrNumber = new int[n]; //массив для номеров команд
                for (int i = 0; i < arr.GetLength(0); i++) //цикл для создания массива номеров комманд
                {
                    arrNumber[i] = i;
                }
                return arrNumber;
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

            for(int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine($"{i + 1} место у команды {arrNumber[i]}");
            }
        }
    }
}
