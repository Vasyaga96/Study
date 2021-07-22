using System;

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

        static void HalfIntervalMethod(int[] array, int number)
        {
            int start = 0;
            int center = 0;
            int end = 0;
            bool found = true;
            /*end = number - 1  почему то в пайтоне было вот так*/
            end = number;
            center = (start + end) / 2;
            while (array[center] != number)
            {
                if (start >= end)
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
            }
            if (found)
            {
                Console.WriteLine($"Ваше число под индексом {center}");
            }
            else
            {
                Console.WriteLine("Такого числа нету");
            }
        }

            static void Main(string[] args)
        {

            /*Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Input(n);

            Seal(arr);

            int max = Maximum(arr);
            Console.WriteLine($"Самое большое число в массиве {arr[max]} под инсдексом {max}");

            int min = Minimum(arr);
            Console.WriteLine($"Самое маленькое число в массиве {arr[min]} под индексом {min}");

            Console.WriteLine("Рандомный массив");
            Seal(RandomArr(n, 1, 10));

            Console.WriteLine("Сортировка рандомного массива");
            int [] randomArr = RandomArr(n, 1, 10);
            Seal(sort(randomArr));*/

            int[] arrayForHalfIntervalMethod = new int[10];
            for (int i = 0; i <= arrayForHalfIntervalMethod.Length - 1; i++)
            {
                arrayForHalfIntervalMethod[i] = i + 1;
            }
            Seal(arrayForHalfIntervalMethod);
            HalfIntervalMethod(arrayForHalfIntervalMethod, 3);
        }
    }
}