﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloName_Lesson
{
    /// <summary>
    /// Создайте массив целых чисел. Напишете программу,
	/// которая выводит сообщение о том, входит ли заданное число в массив или нет.Пусть число для поиска задается с консоли.
    /// </summary>
    internal class Lesson3
	{
        public static void HomeTask3_1()
        {
            int[] Array = { 1, 2, 3, 4, 4, 3, 2, 1 };

            Console.WriteLine("Enter the number to check its existence in the Array:" + "\n");
            float NumberFromConsole = float.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (NumberFromConsole == Array[i])
                {
                    count++;
                }   
            }
            if (count > 0)
            {
                Console.WriteLine("\n" + "Current number exists in the Array " + count + " time(s)");
            }
            else
            {
                Console.WriteLine("\n" + "Current number does not exist in the Array");
            }
        }

        /// <summary>
        /// Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        /// В результате должен быть новый массив без указанного числа.
        /// </summary>

        public static void HomeTask3_2()
        {
            int[] Array = { 1, 2, 1, 3, 4, 3, 1, 4, 5 };
            int count = 0;

            //Вывод всех элементов
            Console.WriteLine("Elements before deletion:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + Array[i]);
            }

            //Ввод числа с клавиатуры
            Console.WriteLine("\n" +"Enter the number to delete it from the Array:");
            int NumberFromConsole = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Основной цикл
            for (int i = 0; i < Array.Length; i++) 
            {
                if (NumberFromConsole == Array[i])
                {
                    count++;
                    for (int j = i; j < Array.Length - count; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                }
            }

            //Вывод сообщения в консоль/Вывод нового массива
            if (count == 0)
            {
                Console.WriteLine("This number does not existing in the array");
            }
            else if (count != 0)
            {
                Console.WriteLine("Elements after deletion: ");
                for (int j = 0; j < Array.Length - count; j++)
                {
                    Console.WriteLine("Element[" + (j) + "]: " + Array[j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
         /// Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
         /// Для генерации случайного числа используйте метод Random() .
         /// Пусть будет возможность создавать массив произвольного размера.
         /// Пусть размер массива вводится с консоли.
         /// </summary>
         /// 
        public static void HomeTask3_3()
        {
            Random random = new Random();
            Console.WriteLine("Enter the size of the Array: ");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                array[i] = (int)random.NextInt64(1, 10);
            }

            //Вывод всех элементов
            Console.WriteLine("\n" + "All Elements of the Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + array[i]);
            }

            int maximum = array[0];
            int minimum = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
                else if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }

            float SumOfAllElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                SumOfAllElements += array[i];
            }
            float average = SumOfAllElements / ArraySize;

            Console.WriteLine("\n" + "The highest number: " + maximum);
            Console.WriteLine("\n" + "The minimum number: " + minimum);
            Console.WriteLine("\n" + "Summary: " + average);
        }

        /// <summary>
        /// Создайте 2 массива из 5 чисел.Выведите массивы на консоль в двух отдельных строках.
        /// Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше
        /// (либо сообщите, что их средние арифметические равны).
        /// </summary>

        public static void HomeTask3_4()
        {
            int[] array1 = { 4, 3, 1, 8, 6 };
            int[] array2 = { 1, 8, 3, 4, 6 };

            float SumOfAllElements1 = 0;
            Console.WriteLine("First array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
                SumOfAllElements1 += array1[i];
            }

            float average1 = SumOfAllElements1 / array1.Length;
            Console.WriteLine("\n" + "Average value of the first array: " + average1 + "\n");

            float SumOfAllElements2 = 0;
            Console.WriteLine("Second array: ");
            for (int j = 0; j < array2.Length; j++)
            {
                Console.Write(array2[j] + " ");
                SumOfAllElements2 += array2[j];
            }

            float average2 = SumOfAllElements2 / array2.Length;
            Console.WriteLine("\n" + "Average value of the second array: " + average2);

            if (SumOfAllElements1 > SumOfAllElements2)
            {
                Console.WriteLine("\n" + "The average value of the first array is greater than the second");
            }
            else if (SumOfAllElements1 == SumOfAllElements2)
            {
                Console.WriteLine("\n" + "The average value of the first and second arrays is equal");
            }
            else
            {
                Console.WriteLine("\n" + "The average value of the first array is less than the second");
            }
        }
    }
}