using System;

namespace Comand2
{
    class Program
    {
        static int[,] GeneratingRandomScoresInTwoDimencionalArray(int CountCommand, int Countompetitions)
        {
            int[,] arr = new int[CountCommand, Countompetitions]; //массив команд и соревнований 
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
        static int[] CountSumOfPoints(int[,] arr)
        {
            int[] arrPoint = new int[arr.GetLength(0)]; //массив для суммы очков каждой команды
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
        static int[] NumberComand(int[,] arr)
        {
            int[] arrNumber = new int[arr.GetLength(0)]; //массив для номеров команд
            for (int i = 0; i < arr.GetLength(0); i++) //цикл для создания массива номеров комманд
            {
                arrNumber[i] = i;
            }
            return arrNumber;
        }

        static int[] SortTwoArray(int[] numberCommand, int[] point)
        {
            bool needSort = true;
            while (needSort)
            {
                needSort = false;
                for (int i = 0; i < point.Length - 1; i++)
                {
                    if (point[i] > point[i + 1])
                    {
                        int k = point[i];
                        point[i] = point[i + 1];
                        point[i + 1] = k;
                        int l = numberCommand[i];
                        numberCommand[i] = numberCommand[i + 1];
                        numberCommand[i + 1] = l;
                        needSort = true;
                    }
                }
            }
            return numberCommand;
        }
        static void PrintArrTeamsByTheNumbersOfPointsScored(int[] arr)
        {              
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} место у команды {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество комманд");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество соревнований");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = GeneratingRandomScoresInTwoDimencionalArray(n, m);

            PrintArrTeamsByTheNumbersOfPointsScored(SortTwoArray(NumberComand(arr), CountSumOfPoints(arr)));
        }
    }
}
