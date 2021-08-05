using System;
using System.Collections.Generic;

namespace array2
{
    class Program
    {
        /*метод генерации массива случайным образом*/
        static int[] RandomArr(int size, int startRange, int endRange)
        {
            int[] randomArr = new int [size];
            Random rnd = new Random();
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rnd.Next(startRange, endRange);
            }
            return randomArr;
        }
        /*Метод для ввода чисел в созданный массив размером size*/
        static int[] Input(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} число массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        /*Метод поиска индекса минимального числа массива*/
        private static int Minimum(int[] arr)
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[index])
                {
                    index = i;
                }
            }
            return index;
        }
        /*Метод поиска индекса максимального числа массива*/
        private static int Maximum(int[] arr)
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[index])
                {
                    index = i;
                }
            }
            return index;
        }
        /*Метод для поиска определенного числа, принимает массив и число которое нужно найти*/
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
        /*Метод для печати массива принимает массив*/
        static void Seal(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);
        }
        /*Метод сортировки пузырём*/
        static int[] sort(int[] arr)
        {
            bool needSort = true;
            while (needSort)
            {
                needSort = false;
                for (int i = 0; i < arr.Length - 1; i++)
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
        /*Метод нахождения половинным делением*/
        static int HalfIntervalMethod(int[] array, int number)
        {
            int start = 0;
            int center = 0;
            int end = 0;
            bool found = true;
            end = array.Length - 1;
            center = (start + end) / 2;
            while (array[center] != number)
            {
                if (start > end)
                {
                    found = false;
                    break;
                }
                if (array[center] < number)
                {
                    start = center + 1;
                }
                else if (array[center] > number)
                {
                    end = center - 1;
                }
                center = (start + end) / 2;

                if (found)
                {
                    return center;
                }
                else
                {
                    return -1;
                }
            }
        }
        /*Метод создание динамического массива*/
        static List<int> DinamicArray()
        {
            List<int> array = new List<int>();
            Console.WriteLine("Введите число");
            int z = Convert.ToInt32(Console.ReadLine());
            while (z != 0)
            {
                array.Add(z);
                z = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        /*Метод вывода динамического массива*/
        static void SealDinamicArray(List<int> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[array.Count - 1]);
        }
        /*Метод подсчёта суммы динамического массива*/
        static int SumDinamicArray(List<int> dinamicArray)
        {
            int sum = 0;
            for (int i = 0; i < dinamicArray.Count; i++)
            {
                sum += dinamicArray[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {            
            /*Поиск половинным делением*/
            int[] arrayForHalfIntervalMethod = RandomArr(10, 1, 10);
            Seal(arrayForHalfIntervalMethod);
            int foundIndexNumber = HalfIntervalMethod(arrayForHalfIntervalMethod, 3);
            if (foundIndexNumber > 0)
                {
                    Console.WriteLine($"Ваше число под индексом {foundIndexNumber}");
                } 
            else
                {
                    Console.WriteLine($"Такого числа нету");
                }

            /*Создание динамического массива и подсчет суммы*/
            List<int> dinamicArray = DinamicArray();
            SealDinamicArray(dinamicArray);           
            Console.WriteLine($"Сумма ваших чисел {SumDinamicArray(dinamicArray)}");

            /*Нахождение максимальной последовательности*/
            /*Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr.Add(rnd.Next(1, 100));
            }

            for (int i = 0; i < arr.Count - 2; i++)
            {
                Console.Write($"{arr[i]},");
            }
            Console.WriteLine($"{arr[arr.Count - 1]}");

            List<int> sequenceLength = new List<int>();


            List<int> sequence = new List<int>();
            sequence.Add(arr[0]);

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    sequence.Add(arr[i]);
                }
                else
                {
                    sequenceLength.Add(sequence.Count);
                    int memorLength = sequence.Count;
                    for (int j = memorLength - 1; j >= 0; j--)
                    {
                        sequence.RemoveAt(j);
                    }
                    sequence.Add(arr[i]);
                }
            }
            sequenceLength.Add(sequence.Count);
            int max = 0;
            for (int i = 1; i < sequenceLength.Count; i++)
            {
                if (sequenceLength[i] >= sequenceLength[max])
                {
                    max = i;
                }
            }
            Console.WriteLine($"Максимальная последовательность {max}");*/
        }
    }
}