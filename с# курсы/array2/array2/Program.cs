using System;
using System.Collections.Generic;

namespace array2
{
    class Program
    {
        /// <summary>
        /// Метод генерации массива случайным образом
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <param name="startRange">начало случайных чисел</param>
        /// <param name="endRange">конец случайных чисел</param>
        /// <returns>Массив случайных чисел</returns>
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
        /// <summary>
        /// Метод для ввода чисел пользователем в массив с заданным размером
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <returns>Массив с введенными пользователем числами</returns>
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
        /// <summary>
        /// Метод поиска индекса минимального числа массива
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>Индекс минимального числа массива arr</returns>
        private static int MinimumNumberInArray(int[] arr)
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
        /// <summary>
        /// Метод поиска индекса максимального числа массива
        /// </summary>
        /// <param name="arr">массив</param>
        /// <returns>Индекс максимального числа массива arr</returns>
        private static int MaximumNumberInArray(int[] arr)
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
        /// <summary>
        /// Метод для поиска индекса числа в массиве
        /// </summary>
        /// <param name="arr">массив</param>
        /// <param name="numberSearch">число которое нужно найти</param>
        /// <returns>Индекс найденного числа</returns>
        static int SearchIndexNumber(int[] arr, int numberSearch)
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
        /// <summary>
        /// Метод для печати статического массива
        /// </summary>
        /// <param name="array">статический массив</param>
        static void SealArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);
        }
        /// <summary>
        /// Метод сортировки пузырём
        /// </summary>
        /// <param name="arr">статический массив</param>
        /// <returns>Отсортированный массив</returns>
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
        /// <summary>
        /// Метод поиска индекса числа половинным делением 
        /// </summary>
        /// <param name="array">статический массив</param>
        /// <param name="number">число, индекс которого нужно найти</param>
        /// <returns>если число есть то его индекс. 
        /// Если числа нету -1</returns>
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
            }
                            return -1;
        }
        /// <summary>
        /// Метод ввода пользователем чисел 
        /// в динамический массив пока не будет введено 0
        /// </summary>
        /// <returns>Динамический массив с введенными
        /// пользователем числами</returns>
        static List<int> InputDimanicArray()
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
        /// <summary>
        /// Метод печати динамического массива
        /// </summary>
        /// <param name="array">динамический массив</param>
        static void SealDinamicArray(List<int> array)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine(array[array.Count - 1]);
        }
        /// <summary>
        /// Метод подсчёта суммы чисел динамического массива
        /// </summary>
        /// <param name="dinamicArray">динамический массив</param>
        /// <returns>Сумма чисел динамического массива</returns>
        static int SumDinamicArray(List<int> dinamicArray)
        {
            int sum = 0;
            for (int i = 0; i < dinamicArray.Count; i++)
            {
                sum += dinamicArray[i];
            }
            return sum;
        }
        /// <summary>
        /// Метод создания динамического массива 
        /// рандомных чисел от 1 до 100
        /// с заданной длиной 
        /// </summary>
        /// <param name="size">длинна массива</param>
        /// <returns>Динамический массив рандомных чисел от 1 до 100</returns>
        static List<int> RandomDinamicArray(int size)
        {
            List<int> arr = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr.Add(rnd.Next(1, 100));
            }
            return arr;
        }
        /// <summary>
        /// Нахождение последней максимальной последовательности
        /// </summary>
        /// <param name="arr">динамический массив</param>
        /// <returns>последняя максимальная последовательность массива</returns>
        static int MaxSequence(List<int> arr)
        {
            int sequence = 1;
            int maxSequence = 0;
            for (int i = 1; i < arr.Count - 1; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    sequence += 1;
                }
                else
                {
                    if (sequence > maxSequence )
                    {
                        maxSequence = sequence;
                    }
                    sequence = 0;
                }            
            }
            return maxSequence;
        }
        /// <summary>
        /// Нахождение последней максимальной последовательности с помощью массивов
        /// </summary>
        /// <param name="arr">динамический массив</param>
        /// <returns>последняя максимальная последовательность</returns>
        static int MaxSequenceUsingArray(List<int> arr)
        {
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
            return max;
        }
        static void Main(string[] args)
        {
            #region поиск половинным делением
            int[] arrayForHalfIntervalMethod = RandomArr(10, 1, 10);
            SealArray(arrayForHalfIntervalMethod);
            int foundIndexNumber = HalfIntervalMethod(arrayForHalfIntervalMethod, 3);
            if (foundIndexNumber > 0)
            {
                Console.WriteLine($"Ваше число под индексом {foundIndexNumber}");
            }
            else
            {
                Console.WriteLine($"Такого числа нету");
            }
            #endregion
            #region Создание динамического массива и подсчет суммы
            List<int> dinamicArray = InputDimanicArray();
            SealDinamicArray(dinamicArray);
            Console.WriteLine($"Сумма ваших чисел {SumDinamicArray(dinamicArray)}");
            #endregion
            #region Нахождение максимальной последовательности
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> arrForSearchSequence = RandomDinamicArray(size);
            SealDinamicArray(arrForSearchSequence);
            int maxSequence = MaxSequence(arrForSearchSequence);
            Console.WriteLine($"Максимальная последовательность{maxSequence}");
            #endregion
        }
    }
}